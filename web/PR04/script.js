let messages = [];

function OnLoadMes()
{
    document.getElementById("Messages").innerHTML = "";
    for (i = 0; i<messages.length; i++)
    {
        document.getElementById("Messages").innerHTML += messages[i];
    }
    
}

sender1 = document.getElementById("sender1")
sender1.onclick = OnLoadMes;
sender1.SenderBtn1.onclick = AddMessSender1;
sender2 =  document.getElementById("sender2")
sender2.SenderBtn2.onclick = AddMessSender2;
sender2.onclick = OnLoadMes;

function AddMessSender1()
{
    message = sender1.SenderText1.value;
    if (message)
    {
        time = Date();
        sender = "Пользователь №1";
        messages.push('<div class="sender1"><p>'+sender+'</p><h3>'+message+'</h3><p>'+time+'</p></div>')
        sender1.SenderText1.value = "";
    }
}
function AddMessSender2()
{
    message = sender2.SenderText2.value;
    if (message)
    {
        time = Date();
        sender = "Пользователь №2";
        messages.push('<div class="sender2"><p>'+sender+'</p><h3>'+message+'</h3><p>'+time+'</p></div>')
        sender2.SenderText2.value = "";
    }
}
document.getElementById("clearAll").onclick = clearAll;
document.getElementById("clearFirst").onclick = clearFirst;
document.getElementById("clearLast").onclick = clearLast;
function clearAll()
{
    messages = [];
    OnLoadMes();
}
function clearFirst()
{
    messages.shift();
    OnLoadMes();
}
function clearLast()
{
    messages.pop();
    OnLoadMes();
}

 