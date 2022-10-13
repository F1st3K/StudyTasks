<?php 
function FindRemainderOfSeconds($h, $m, $s)
{
    $m += $h * 60;
    $s += $m * 60;
    $ost = 86400 - $s;
    return $ost;
}
?>