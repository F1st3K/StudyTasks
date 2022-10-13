let InfoOutput = document.getElementById("output");
let login = document.getElementById("userId");
let query = "?usr=";
let RequestAddress = "http://xn--80aaghdqfmgbznzk1h1c8b.xn--p1ai/zamt000webhostappcom/pr08.php/pr08.php";

function MakeRequest()
{
    let MainRequest = new XMLHttpRequest;
    MainRequest.open("GET", RequestAddress + query + login.value, true);
    MainRequest.onreadystatechange = function ()
    {
        if(MainRequest.readyState == 4 && MainRequest.status == 200)
            InfoOutput.innerHTML = "<p>" + MainRequest.responseText + "<p>" + InfoOutput.innerHTML;
    }
    MainRequest.send();
}
