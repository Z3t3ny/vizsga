<?php

    $result = $connection->query("SELECT * FROM nevnap WHERE nev1 ='$getName' OR nev2 = '$getName'");
    $row = $result->fetsch_assoc();

    if($result->num_rows == 0) 
    {
        $key   = "hiba";
        $value = "nincs találat";

    }else{
        $key   = "datum";
        $value = date("F", mktime(0, 0, 0, $row["ho"], $row["nap"]) . " " . $row["nap"])
    }

    array[

        $key -> $value
    ];

?>