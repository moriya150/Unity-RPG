<?php

require_once('rpg_connect.php');
$db = connectDB();

$NAME       = $_POST["NAME"];
$LV         = $_POST["LV"];
$KISO_HP    = $_POST["KISO_HP"];
$KISO_AT    = $_POST["KISO_AT"];
$KISO_DEF   = $_POST["KISO_DEF"];
$EXP        = $_POST["EXP"];
$SOUBI_HP   = $_POST["SOUBI_HP"];
$SOUBI_AT   = $_POST["SOUBI_AT"];
$SOUBI_DEF  = $_POST["SOUBI_DEF"]; 

$sql = "UPDATE `playertable` SET LV = '".$LV."', KISO_HP ='".$KISO_HP."', KISO_AT = '".$KISO_AT."', KISO_DEF = '".$KISO_DEF."', EXP = '".$EXP."',SOUBI_HP = '".$SOUBI_HP."' ,SOUBI_AT = '".$SOUBI_AT."' ,SOUBI_DEF = '".$SOUBI_DEF."' WHERE `NAME` = '".$NAME."'";

    $result = mysqli_query($db, $sql);



    $db = mysqli_close($db);

    if(!$db)
    {
        exit('データベースとの接続を閉じられませんでした。');
    }

    //echo $RANK;
?>