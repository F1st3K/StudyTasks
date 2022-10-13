
function res_square_cube(){
    var sp, sg, a = 0;
    a = parseFloat (frst.a.value);
    sp = String(a*a*6);
    sg = String(a*a);
    v = String(a*a*a);
    alert(
        "Площадь грани куба: "+sg+
        "Площадь поверхности куба: "+sp+
        "обьем куба: "+v
    );
}

function res_square_seconds(){
    var h, m, s, rest_s= 0;
    rest_s = 86400;
    h = parseFloat (frst2.h.value);
    m = parseFloat (frst2.m.value);
    s = parseFloat (frst2.s.value) + h*3600 + m*60;
    rest_s -= s;

    alert(
        "На сегодня секунд осталось: "+String(rest_s)
    );
}

function res_square_metr(){
    var t, g, m = 0;
    g = parseFloat (frst3.g.value);
    t = parseFloat (frst3.t.value);
    m = String (t*t*g)
    
    alert(
        "Высота падения камня: "+m+
        " метров"
    );
}