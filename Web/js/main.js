'use strict';
var timeFPS = Date.now(),
    fps = 0;

window.requestAnimFrame = (function () {
    return window.requestAnimationFrame       ||
        window.webkitRequestAnimationFrame ||
        window.mozRequestAnimationFrame    ||
        window.oRequestAnimationFrame      ||
        window.msRequestAnimationFrame     ||
        function (callback, element) {
            window.setTimeout(callback, 1000 / 60);
        };
})();
  

var canvas,
    context,
    tickCount = [],
    frame = [],
    loop = [],
    sprites = {
        fjell2          : "img/fjell2.png",
        fjell1          : "img/fjell1.png",
        gress           : "img/gress2.png",
        fireHouse       : 'img/fire/fire.png',
        bitKingRight    : 'img/bitking/bitking.png',
        bitKingLeft     : 'img/bitking/bitkingLeft.png',
        bitKingIdleLeft : 'img/bitking/bitkingIdleLeft.png',
        bitKingIdleRight : 'img/bitking/bitkingIdleRight.png',
        cloud1          : 'img/cloud1.png',
        cloud2          : 'img/cloud2.png',
        cloud3          : 'img/cloud3.png',
        dirt            : 'img/dirt.png'
    };

    canvas = document.createElement( 'canvas' );
    canvas.width = window.innerWidth;
    canvas.height = window.innerHeight;

var keyCodes = {
        w : 87,
        s : 83,
        a : 65,
        d : 68,
        esc : 27,
        enter : 13,
        space : 32,
        ArrowDown : 40,
        ArrowRight : 39,
        ArrowUp : 38,
        ArrowLeft : 37
    },
    pressedKeys = {},
    bitking = {
        x : 0,
        y : 0,
        sprite : 0,
        speed : 8,
        move : false,
        velosity: 0,
        baseVelosity : 2.8,
        vy : 0,
        baseY : canvas.height - 260,
        isJumping : false,
        jumpHeight : 20
    };

document.addEventListener("keydown", function (e) {
    pressedKeys[e.keyCode] = true;
});
document.addEventListener("keyup", function (e) {
    pressedKeys[e.keyCode] = false;
});


function rng(min, max) {
    return Math.floor(Math.random() * (max - min)) + min;
}

function drawFPS() {
    context.font = "20px Verdana";
    context.fillStyle = "black";
    context.fillText(Math.floor(fps) + "FPS", 10, 30);
}

function AnimateSprite(sprite,
                       NumOfFrames,
                       tickPerFrame,
                       frameWidth,
                       frameHeight,
                       frameScale,
                       x,
                       y,
                       count,
                       pause) {
    //frameWidth = sprite.width / NumOfFrames;
    //frameHeight = sprite.height;
    
    if (!tickCount[count]) {
        tickCount[count] = 0;
    }
    if (!frame[count]) {
        frame[count] = 0;
    }
    
    if (tickCount[count] === NumOfFrames) {
        tickCount[count] = 0;
    }
    
    context.drawImage(sprite, frameWidth * tickCount[count], 0, frameHeight, frameWidth, x, y, frameWidth * frameScale, frameHeight * frameScale);
    
    if (frame[count] >= tickPerFrame) {
        tickCount[count]++;
        frame[count] = 0;
    }
    if(!pause) frame[count]++;
}

function drawImageSprite(img, x, y, s) {
    context.drawImage(img, 0, 0, img.width, img.height, x, y, img.width * s, img.height * s);
}

function loopSprite(img, scale, x, y, count, speed, cols) {
    var w = img.width;
    var h = img.height;
    
    if (!loop[count]) {
        loop[count] = [];
    }
    
    for (var i = 0; i < cols; i++){
        if(!loop[count][i]){
            loop[count][i] = 0;
        }
        var xFormula = w * scale * i + loop[count][i];//* speed/100);
        drawImageSprite(img, xFormula, y, scale, w, h);
        
        context.fillStyle = "#ff8800";
        context.fillRect(xFormula, 0, 10, canvas.height);
        
        if(xFormula < -w*scale){
            loop[count][i] = w*scale * 3;
        }
        loop[count][i]--;
    }
}


function moveSprite(img, scale, x, y, count, speed){
    if(!loop[count]){
        loop[count] = 0;
    }
    var w = img.width;
    var h = img.height;
    
    var xFormula = (x) - (loop[count] * (speed/100));
    drawImageSprite(img, xFormula, y, scale, w, h);
    
    if(xFormula < -w*scale){
        loop[count] = -(w*scale + canvas.width + 100);
    }
    
    loop[count]++;
}
function fill(img, scale, y){
    var c = Math.floor(canvas.width / img.width * scale) + 1;
    if(c == Infinity) c = 20;
    for(var i = 0; i < c; i++){
       drawImageSprite(img, img.width*scale*i, y, scale);
    }
}

function draw() {
    if(bitking.sprite === 0){
        bitking.sprite = sprites.bitKingLeft;
    }
    context.beginPath();
    if(pressedKeys[keyCodes.a] || pressedKeys[keyCodes.ArrowLeft]){
        bitking.x -= bitking.speed;
        bitking.sprite = sprites.bitKingLeft;
    }

    if(pressedKeys[keyCodes.d] || pressedKeys[keyCodes.ArrowRight]){
        bitking.sprite = sprites.bitKingRight;
        bitking.x += bitking.speed;
    }
    
    if((pressedKeys[keyCodes.d] || pressedKeys[keyCodes.a] || pressedKeys[keyCodes.ArrowRight] || pressedKeys[keyCodes.ArrowLeft])  && !bitking.isJumping ){

    } else {
       
        if(bitking.sprite == sprites.bitKingLeft){
             bitking.sprite = sprites.bitKingIdleLeft
        }
        
        if(bitking.sprite == sprites.bitKingRight){
             bitking.sprite = sprites.bitKingIdleRight
        }
       
    }
    
    if((pressedKeys[keyCodes.space] || pressedKeys[keyCodes.w] || pressedKeys[keyCodes.ArrowUp]) && !bitking.isJumping){
        bitking.isJumping = true;
        console.log("jumping")
    }

    if(bitking.isJumping){
        bitking.vy++;
        
        if(bitking.vy < bitking.jumpHeight/10 * bitking.jumpHeight/2){
            bitking.velosity -= bitking.baseVelosity / bitking.jumpHeight;
        }
        
        if(bitking.vy > bitking.jumpHeight/10 * bitking.jumpHeight/2){
            bitking.velosity += bitking.baseVelosity / bitking.jumpHeight;
        }
        
        if(bitking.vy >= bitking.jumpHeight){
            bitking.y += bitking.speed * bitking.velosity;
        } else {
            bitking.y -= bitking.speed * bitking.velosity;
        }
        if(bitking.y > bitking.baseY){
                bitking.isJumping = false;
                bitking.vy = 0;
                bitking.velosity = bitking.baseVelosity;
            }
        
        if(bitking.y > bitking.baseY){
            bitking.y = bitking.baseY;
        }
    }
    //clear canvas
    context.clearRect(0, 0, canvas.width, canvas.height);    
    context.fillStyle = "#7ec0ee";
    context.fillRect(0, 0, canvas.width, canvas.height);
    
    //draw FPS counter
    drawFPS();
    
    
//   loopSprite(sprites.fjell2, 5, 0, 0 ,0, 40, 3);
    drawImageSprite(sprites.fjell2, 0, -30, 5);
    drawImageSprite(sprites.fjell1, 0, 200, 5);
    
    moveSprite(sprites.cloud1, 5, 500, -20, 2, 10);
    moveSprite(sprites.cloud2, 5, 700, 50, 3, 20);
    moveSprite(sprites.cloud3, 5, 900, 20, 4, 30);

   fill(sprites.dirt, 2, canvas.height - sprites.dirt.height * 2);
    
    AnimateSprite(sprites.fireHouse, 10, 5, 299, 299, 3, canvas.width/2 - 299*3/2, canvas.height - 500, 0, false);
  
    fill(sprites.gress, 3, canvas.height - 160);
    
    AnimateSprite(bitking.sprite, 8, 5, 62, 60, 3, bitking.x, bitking.y, 1, bitking.move);
    fill(sprites.gress, 3, canvas.height - 135);
    
    context.closePath();
    context.fill();
}

function animate() {
    requestAnimFrame( animate );
    var delta = (Date.now() - timeFPS)/1000;
    timeFPS = Date.now();
    fps = 1/delta;
    
    draw();
}
var spriteCount = 0;
var totalSprites = 0;
var spriteBarCount = 0;
for (var key in sprites) {
    if (sprites.hasOwnProperty(key)) {
        spriteCount++;
        totalSprites++;
    }
}
function drawLoadingScreen(){
    context.beginPath();
    context.fillStyle = "#7ec0ee";
    context.fillRect(0, 0, canvas.width, canvas.height);
    
    context.fillStyle = "#222222";
    context.font = "40px areal"
    context.fillText("Loading...", canvas.width / 2 - 75, canvas.height / 2 - 50);
    
    context.fillStyle = "#f8f8f8";
    context.fillRect(canvas.width / 2 - 200, canvas.height / 2 - 25, 400, 50);
    
    context.fillStyle = "#222222";
    context.fillRect(canvas.width / 2 - 200, canvas.height / 2 - 25, (400 / totalSprites) * spriteBarCount, 50);
    
    context.closePath();
}

function loadGame(){
    spriteCount--;
    spriteBarCount++;
    
    drawLoadingScreen();
    
    if (spriteCount === 0) {
       animate();
    }
}

function init() { 
    context = canvas.getContext( '2d' );
    context.imageSmoothingEnabled = false;
    context.mozImageSmoothingEnabled = false;
    document.body.appendChild( canvas );
    drawLoadingScreen();
    
    for (var key in sprites) {
        if (sprites.hasOwnProperty(key)) {
            var placeholderImg = new Image();
            placeholderImg.src = sprites[key];
            sprites[key] = placeholderImg;
            sprites[key].addEventListener("load", loadGame);
        }
    }
    bitking.y = bitking.baseY;
}
init();
