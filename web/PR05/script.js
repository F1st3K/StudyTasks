let prevCordX = null;
let prevCordY = null;
let pressCordX = null;
let pressCordY = null;
let mayClick = true;
window.addEventListener("click", function (event){Click(event)})
function Click(event)
{
    if (prevCordX!=null && prevCordY!=null)
    {
        pressCordX = event.pageX-50;
        pressCordY = event.pageY-50;
        mayClick = false;
        MovePicture();
        mayClick = true;
    }
    else
    {
        prevCordX = event.pageX-50;
        prevCordY = event.pageY-50;
    }
}
function MovePicture()
{
    let picture = document.getElementById("rubl");
    picture.style.left = prevCordX+"px";
    picture.style.top = prevCordY+"px";
    let x = prevCordX;
    let y = prevCordY;
    let MainInterval = setInterval(function(){
        if (prevCordX < pressCordX) 
        {
            if (x>pressCordX)
            {   
                prevCordX = null;
                prevCordY = null;
                clearInterval(MainInterval);
            }
            x += 1;
        }
        else if (prevCordX >= pressCordX) 
        {
            if (x<pressCordX)
            {
                prevCordX = null;
                prevCordY = null;
                clearInterval(MainInterval);
            }
            x -= 1;
        }
        y = ((x - prevCordX) * (pressCordY - prevCordY)) / (pressCordX - prevCordX) + prevCordY;
        picture.style.left = x + "px";
        picture.style.top = y + "px";
    }, 10);
}
