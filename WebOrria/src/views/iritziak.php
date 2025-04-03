<!DOCTYPE html>
<html>

<head>
    <link rel="stylesheet" type="text/css" href="../../public/css/css.css">
    <title>Iritziak</title>
</head>

<body class="main-grid">
    <?php require_once 'parts/header.php'; ?>
    <main>
        <form method="post" action="" class="iritziakFormularioa">
            <label for="erabiltzaileaIritzi" class="iritziakLabel">Erabiltzailea:</label>
            <input type="text" id="erabiltzaileaIritzi" name="erabiltzaileaIritzi" class="iritziakInput" required>
            <label for="iritzia">Zure iritzia:</label>
            <textarea id="iritzia" name="iritzia" required></textarea>
            <button type="submit">Argitaratu</button>
        </form>

        <?php
        if ($_SERVER['REQUEST_METHOD'] === 'POST' && !empty($_POST['iritzia']) && !empty($_POST['erabiltzaileaIritzi'])) {
            $erabiltzailea = htmlspecialchars($_POST['erabiltzaileaIritzi']);
            $iritzia = htmlspecialchars($_POST['iritzia']);
            $xml = new SimpleXMLElement('<iritziak/>');

            if (file_exists('iritziak.xml')) {
                $xml = simplexml_load_file('iritziak.xml');
            }
            
            $iritziaBerria = $xml->addChild('iritzia');
            $iritziaBerria->addChild('erabiltzailea', $erabiltzailea);
            $iritziaBerria->addChild('testua', $iritzia);

            $xml->asXML('iritziak.xml');
        }

        if (file_exists('iritziak.xml')) {
            $xml = simplexml_load_file('iritziak.xml');
            echo '<h2 class=iritziakIzenburua>Iritziak:</h2>';
            foreach ($xml->iritzia as $iritzia) {
                echo '<p class=iritziakErabiltzailea>'. $iritzia->erabiltzailea . '</p>';
                echo '<p class=iritziakTextua>' . $iritzia->testua . '</p>';
            }
        }
        ?>
    </main>
    <?php require_once 'parts/footer.php'; ?>
</body>

</html>