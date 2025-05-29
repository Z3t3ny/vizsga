<?php

$sor = explode('-', $getDate) ;
$month = $sor[0];
$day = $sor[1];
$value2 = null;

$result =  $connect->query("SELECT * FROM nevnap WHERE ho = '$month' AND nap = '$day'");
$row    =  $result->fetch_assoc();


if($result->num_rows == 0) 
    {
        $key   = "hiba";
        $value = "nincs találat";

    }else{
        $key   = "datum";
        $value = date("F", mktime(0, 0, 0, $month, $day)) . " " . $day;
        
        $key2   = "nevnap1";
        $value2 = $row["nev1"] ?? null ;

        $key3   = "nevnap2";
        $value3 = $row["nev2"] ?? null ;

    }

if($value2)
{
    $array = [

    $key -> $value,
    $key2 -> $value2,
    $key3 -> $value3
];
}else{
    $array = [
        $key -> $value
    ];
}



$json = json_encode($array, JSON_UNESCAPED_UNICODE | JSON_PRETTY_PRINT);

echo $json;

?>