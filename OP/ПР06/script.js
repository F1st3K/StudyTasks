
function res_square(){
    let h , AB, square, a = 0;
    h = Number (prompt("Введите высоту треугольника h"));
    AB = Number (prompt("Введите длинну основания треугольника AB"));
    for  (let i = 0; i < 5; i++)
    {
        square = 0.5*h*(AB+a);
        
        switch (a)
        {
            case 0:
                document.getElementById("res1").innerText = square;
                break;

            case 1:
                document.getElementById("res2").innerText = square;
                break;

            case 2:
                document.getElementById("res3").innerText = square;
                break;

            case 3:
                document.getElementById("res4").innerText = square;
                break;

            case 4:
                document.getElementById("res5").innerText = square;
                break;
        }
        a++;
    }
}