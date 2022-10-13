<?php 
function FindHeightByAcceleration($h1=100, $a2=14.6, $a1 = 9.8)
{
    $t = ($h1/$a1)**1/2;
    $h2 = ($a2*$t**2)/2;
    return $h2;
}
?>
