<?php

    require_once('rpg_connect.php');
    $db = connectDB();

    $NAME = $_POST["NAME"];

    $sql = 'INSERT INTO playertable (NAME,LV,KISO_HP,KISO_AT,KISO_DEF ,EXP,SOUBI_HP,SOUBI_AT,SOUBI_DEF) VALUES ("'.$NAME.'",1,100,25,5,0,0,0,0)';

    $result = mysqli_query($db, $sql);

    $db = mysqli_close($db);

    if(!$db)
    {
        exit('データベースとの接続を閉じられませんでした。');
    }
?>