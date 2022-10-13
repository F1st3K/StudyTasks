let findLagestDigit =
{
    strNum :"0000",

    goCompare(frsDig, bigDig)
    {
        return frsDig > bigDig ? frsDig : bigDig
    },

    goFind()
    {
        let bigDig = this.strNum[0]
        for(i=0; i<this.strNum.length; i++)
        {
           bigDig = this.goCompare(this.strNum[i+1], bigDig)
        }
        return bigDig
    },
}
function F1()
{
    findLagestDigit.strNum = prompt("Введите число: ")
    alert(findLagestDigit.goFind())
}

let findByRadius =
{
    radius : 0,
    h : 0,

    findCircum()
    {
        return 2*3.14*this.radius
    },

    findSquare()
    {
        return this.findCircum()*this.radius/2
    },

    findVolume()
    {
        return this.findSquare()*this.h
    },
}
function F2()
{
    findByRadius.radius = Number(prompt("Введите радиус: "))
    findByRadius.h = Number(prompt("Введите высоту цилиндра: "))
    alert
    (
        "Длинна окружности: " + findByRadius.findCircum() + "\n"+
        "Площадь окружности: " + findByRadius.findSquare() + "\n"+
        "Обьем цилиндра: " + findByRadius.findVolume() + "\n"
    )
}

let findBySquareArea =
{
    square : 0,
    
    findRadiusInsCicle()
    {
        return this.square**(1/2)/2
    },
}
function F3()
{
    findBySquareArea.square = Number(prompt("Введите площадь квадрата: "))
    alert("Радиус вписанной окружности равен: " + findBySquareArea.findRadiusInsCicle())
}