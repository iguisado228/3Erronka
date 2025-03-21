<?php

function konexioaSortu()
{
    $servername = "172.16.237.150";
    $username = "langilea";
    $password = "1234";
    $dbname = "erronka3";
    
    $conn = new mysqli($servername, $username, $password, $dbname);
    
    if ($conn->connect_error) {
        die("Konexioan hurrengo errorea gertatu da: " . $conn->connect_error);
    }

    return $conn;
}
?>