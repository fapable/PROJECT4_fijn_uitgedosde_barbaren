<?php
    /*
    ============================================================

        PHP Web API -> Project 4 - Fijn Uitgedoste Barbaren
        BASE URL: http://www.wschaijk.nl/api/api.php/{METHOD}/{SQL}

    ============================================================
     */

    // connect to the mysql database
    $link = mysqli_connect('rdbms.strato.de', 'U2936761', 'Admin001', 'DB2936761');
    mysqli_set_charset($link,'utf8');

    // Get the information from the URL
    $input = json_decode(file_get_contents('php://input'),true);
    $request = explode('/', trim($_SERVER['PATH_INFO'],'/'));

    // retrieve the table from the path
    $rawData = array_shift($request);
    $sql = str_replace("-", " ", $rawData);
    $method = replace($rawData);

    // excecute SQL statement
    $result = mysqli_query($link, $sql);

    // die if SQL statement failed
    if (!$result) {
        http_response_code(404);
        print("<h1>ERROR: 404 NOT FOUND</h1>");
        print("SQL: " . $sql . "\nMethod: " . $method);
        die(mysqli_error());
    }

    // print results, insert id or affected row count
    if ($method == 'SELECT') {
        if (mysqli_num_rows($result) > 1) echo '[';
        for ($i=0; $i < mysqli_num_rows($result); $i++) {
            echo ($i>0?',':'').json_encode(mysqli_fetch_object($result));
        }
        if (mysqli_num_rows($result) > 1) echo ']';
    } elseif ($method == 'INSERT') {
        echo mysqli_insert_id($link);
    } else {
        echo mysqli_affected_rows($link);
    }

    // close mysql connection
    mysqli_close($link);

    function replace($string) {
        $array = explode("-", $string);
        return $array[0];
    }