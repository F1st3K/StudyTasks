var img;
var passImg = {name:"image/pass.png", prior:0};
var i = 0;
var mas=[];
var res;
var g;
var white = 0;
var red = 0;
var yellow = 0;
var indees = 0;
var ind = false;
var go;
var time = 0;
function gener(){
    qr=Math.random()
    if      (qr<0.4)            {img={name:"image/white.png",   prior:1,   prop:0}}
    else if (qr>=0.4 && qr<0.6) {img={name:"image/red.png",     prior:1,   prop:0}}
    else if (qr>=0.6 && qr<0.7) {img={name:"image/yellow.png",  prior:1,   prop:0}}
    else if (qr>=0.7 && qr<=1)  {img={name:"image/indees.png",  prior:1,   prop:0}}
    document.images[0].src = img.name;
}
function push(){
    if (img){
        if (i<8){
        mas[i] = img;
        priority()
        i++;
        vis()
        }
        else{
            alert("Очередь заполнена!!!\n Почисти пж)")
        }
    }
}
function priority(){
    g = "";
    for(j=1; j<mas.length; j++){
        if (mas[j].prior < mas[j-1].prior && mas[j].prop == 0){
            [mas[j], mas[j-1]] = [mas[j-1], mas[j]]
        }
        
        g += mas[j].prior + "\n";
    }
}
function clearing(){
    for (j=0; j<8; j++){
        document.images[j+1].src = passImg.name;
    }
    i=0
    mas=[]
    time = 0;
    vis()
}
function unload(){
    if (i>0){
    res = mas.shift()
    document.images[i].src = passImg.name;
    vis()
    i--;
    }
}
function vis(){
    white = 0;
    red = 0;
    yellow = 0;
    indees = 0;
    for(j=0; j<mas.length; j++){
        document.images[j+1].src = mas[j].name;
        switch (mas[j].name){
            case "image/white.png": white++; break;
            case "image/red.png": red++; break;
            case "image/yellow.png": yellow++; break;
            case "image/indees.png": indees++; break;
        }
    }
    document.getElementById("white").innerText = white;
    document.getElementById("red").innerText = red;
    document.getElementById("yellow").innerText = yellow;
    document.getElementById("indees").innerText = indees;
    document.getElementById("time").innerText = time;
}
function start(){
    clearing()
    go = setInterval("main()", 1000)
}
function stop(){
    clearInterval(go)
}
function main(){
    time++
    gener()
    push()
    if (i>6){
        unload()
        unload()
        unload()
        unload()
        unload()
    }
}