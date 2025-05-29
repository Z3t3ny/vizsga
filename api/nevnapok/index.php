<?php

include("connect.php");

header("Content-Type: Application/json; charset=utf-8", JSON_UNESCAPED_UNICODE | JSON_PRETTY_PRINT);

$getDate = $_GET["nap"] ?? null;
$getName = $_GET["nev"] ?? null;


if ($getDate) {
    include("date.php");
} 
if ($getName)   
{
    include("name.php");
}
else{

    $array = [
        "minta1" => "/?nap=12-31",
        "minta2" => "/?nev=Szilveszter"
    ];

    $json = json_encode($array, JSON_UNESCAPED_UNICODE | JSON_PRETTY_PRINT);
    echo $json;
}








?>