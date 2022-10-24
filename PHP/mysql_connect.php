<?php

    function connectDB(){
        $db = new mysqli('localhost', 'root', '', 'exercise');

        if($db->connect_error){
            exit($db->connect_error);
        }

        return $db;
    }

?>