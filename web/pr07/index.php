<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <title>pr07 Kostin</title>
</head>
<body>
    <h1>1. Дана длина ребра куба. Найти площадь грани, площадь полной поверхности и объем этого куба.</h1>
    <?php
    include "FindCube.php";
    $res = FindDimensionsCubeBySide(5);
    echo "площадь грани: $res[0]\n";
    echo "площадь П/П: $res[1]\n";
    echo "Обьем: $res[2]\n";
    
    ?>
    <h1>2. Дано количество часов, минут и секунд с начала суток. Сколько секунд осталось до конца суток ?</h1>
    <?php
    include "FindSeconds.php";
    $ost = FindRemainderOfSeconds(23, 59, 50);
    echo "секунд осталось: $ost";
    ?>
    <h1>3. На Земле с высоты H=100 метров падает камень. \nУскорение свободного падения принять равным 9.8 м/c2.\n С какой высоты тот же камень за то же время упадет на планете с ускорением свободного падения 14.6 м/с2 ?</h1>
    <?php
    include "FindHeight.php";
    $h = FindHeightByAcceleration();
    echo "высота: $h";
    ?>
</body>
</html>