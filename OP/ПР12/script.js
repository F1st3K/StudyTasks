var img;
var passImg = {name:"image/pass.png", prior:0};
let ni, nu;
var i = 0;
var u = 0;
var maso=[];
var mass=[];
var res;
var g;
var ye = true;
var ind = false;
function gener(){
    qr=Math.random()
    if      (qr<0.4)            {img={name:"image/white.png",   ots:"oc"}}
    else if (qr>=0.4 && qr<0.6) {img={name:"image/red.png",     ots:"st"}}
    else if (qr>=0.6 && qr<0.7) {img={name:"image/yellow.png",  ots:"oc"}}
    else if (qr>=0.7 && qr<=1)  {img={name:"image/indees.png",  ots:"st"}}
    document.images[0].src = img.name;
}
function push(){
    if (img.ots == "oc"){
        if (i<5){
        maso[i] = img;
        i++;
        ni = i;
        viso()
        }
        else{
            alert("Очередь заполнена!!!\n Почисти пж)")
        }
    }
    if (img.ots == "st"){
        if (u<5){
        mass[u] = img;
        u++;
        nu = u;
        viss()
        }
        else{
            alert("стэк заполнен!!!\n Почисти пж)")
        }
    }
}
function clearing(){
    for (j=0; j<10; j++){
        document.images[j+1].src = passImg.name;
    }
    i=0;
    u=0;
    maso=[];
    mass=[];
}
function unload(){
    if(ye){
        if (nu>=ni && i>0){
            res = maso.shift()
            document.images[i].src = passImg.name;
            viso()
            i--;
            ni--;
        }
        else{ni=6; ye=false;}
    }
    if(ye == false){
        if (ni>nu && u>0){
            res = mass.splice(-1, 1)
            document.images[u+5].src = passImg.name;
            viss()
            u--;
            nu--;
        }
        else{nu=6; ye=true;}
    }
}
function viss(){
    for(j=0; j<mass.length; j++){
        document.images[j+6].src = mass[j].name;
    }
}
function viso(){
    for(j=0; j<maso.length; j++){
        document.images[j+1].src = maso[j].name;
    }
}