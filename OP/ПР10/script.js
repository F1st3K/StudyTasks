var img;
var passImg = "image/pass.png";
var i = 0;
var mas=[];
var res;
function gener(){
    qr=Math.random()
    if (qr<0.4){img="image/white.png"}
    else if (qr>=0.4 && qr<0.6){img="image/red.png"}
    else if (qr>=0.6 && qr<0.7){img="image/yellow.png"}
    else if (qr>=0.7 && qr<=1){img="image/indees.png"}
    document.images[0].src = img;
}
function push(){
    if (img){
        if (i<8){
        mas[i] = img;
        i++;
        vis()
        }
        else{
            alert("Очередь заполнена!!!\n Почисти пж)")
        }
    }
}
function clearing(){
    for (j=0; j<8; j++){
        document.images[j+1].src = passImg;
    }
    i=0
    mas=[]
}
function unload(){
    if (i>0){
    res = mas.shift()
    document.images[i].src = passImg;
    vis()
    i--;
    }
}
function vis(){
    for(j=0; j<mas.length; j++){
        document.images[j+1].src = mas[j];
    }
}