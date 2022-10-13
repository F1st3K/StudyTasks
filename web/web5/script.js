function F1(){
    let h = prompt("Введите длинну ребра куба: ")
    let Sg = h*h
    let Sp = Sg*6
    let V = Sg*h
    alert(
        "Площадь грани: "+Sg+
        "\nПлощадь полной поверхности: "+Sp+
        "\nОбьем куба: "+V
    )
}
function F2(){
    let h = prompt("Введите количество часов: ")
    let m = prompt("Введите количество минут: ")
    let s = prompt("Введите количество секунд: ")
    s = 86400-(h*3600 + m*60 + s*1)
    alert("Секунд на сегодня осталось: "+s )
}
function F3(){
    let h1 = 100
    let a1 = 9.8
    let a2 = 14.6
    let t = (h1/a1)**1/2
    let h2 = (a2*t**2)/2
    alert("расстояние: "+h2)
}