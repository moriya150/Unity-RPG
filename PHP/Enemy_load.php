<?php

    require_once('rpg_connect.php');
    $db = connectDB();

    $ENEMY_ID = $_POST["ENEMY_ID"];

    $sql = 'SELECT * FROM enemytable WHERE ENEMY_ID = "'.$ENEMY_ID.'"';

    $result = mysqli_query($db, $sql);

    while($data = $result->fetch_assoc())
    {
        $res = $data['ENEMY_ID'];
        $res .= ",".$data['NAME'];
        $res .= ",".$data['HP'];
        $res .= ",".$data['AT'];
        $res .= ",".$data['DEF'];
        $res .= ",".$data['EXP'];
    }

    $db = mysqli_close($db);

    if(!$db)
    {
        exit('データベースとの接続を閉じられませんでした。');
    }

    echo $res;
?>