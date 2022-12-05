<?php

require_once('rpg_connect.php');
$db = connectDB();

$NAME = $_POST["NAME"];


   $sql = 'SELECT * FROM playertable WHERE NAME = "'.$NAME.'" LIMIT 1';

    $result = mysqli_query($db, $sql);

    while($data = $result->fetch_assoc())
    {

        $res = $data['PLAYER_ID'];
        $res .= ",".$data['NAME'];
        $res .= ",".$data['LV'];
        $res .= ",".$data['KISO_HP'];
        $res .= ",".$data['KISO_AT'];
        $res .= ",".$data['KISO_DEF'];
        $res .= ",".$data['EXP'];
        $res .= ",".$data['SOUBI_HP'];
        $res .= ",".$data['SOUBI_AT'];
        $res .= ",".$data['SOUBI_DEF'];
    }


    $db = mysqli_close($db);

    if(!$db)
    {
        exit('データベースとの接続を閉じられませんでした。');
    }

    echo $res;
?>