<?php
function FindDimensionsCubeBySide($a=4)
{
    $Sgr = $a**2;
    $Spp = $Sgr*6;
    $V = $Sgr*$a;
    $res = [$Sgr, $Spp, $V];
    return $res;
}
?>
