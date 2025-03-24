<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" type="text/css" href="../../public/css/css.css">
    <title>Konfigurazioa</title>
</head>

<body class="main-grid">
    <?php require_once 'parts/header.php'; ?>
    <main>
        <div class="konfigurazioKontainerra">
            <h1>Webgunearen Konfigurazioa</h1>

            <?php
            $xml = simplexml_load_file('../../config/settings.xml');
            if (isset($_POST['gorde'])) {
                $xml->hizkuntza = $_POST['hizkuntza'];
                $xml->menuKolorea = $_POST['menuKolorea'];
                $xml->textuKolorea = $_POST['textuKolorea'];
                $xml->atzekaldeKolorea = $_POST['atzekaldeKolorea'];
                
                // Gorde eta cache-a garbitu
                $xml->asXML('../../config/settings.xml');
                clearstatcache();
                
                // XML fitxategia berriro kargatu aldaketak ikusteko
                $xml = simplexml_load_file('../../config/settings.xml');
                
                echo "<p class='ongiAteraDaEmaitza'>Konfigurazioa ondo gorde da!</p>";
                
                // Orria freskatu kolore berriak ikusteko
                echo "<meta http-equiv='refresh' content='1'>";
            }

            if (isset($_POST['berrezarri'])) {
                $xml->menuKolorea = "#2c3e50";
                $xml->textuKolorea = "#ffffff";
                $xml->atzekaldeKolorea = "#ffffff";
                
                // Gorde eta cache-a garbitu
                $xml->asXML('../../config/settings.xml');
                clearstatcache();
                
                // XML fitxategia berriro kargatu aldaketak ikusteko
                $xml = simplexml_load_file('../../config/settings.xml');
                
                echo "<p class='ongiAteraDaEmaitza'>Koloreak berrezarri dira!</p>";
                
                // Orria freskatu kolore berriak ikusteko
                echo "<meta http-equiv='refresh' content='1'>";
            }
            ?>

            <form method="POST" class="konfigurazioFormularioa">
                <div class="konfigurazioAukerak">
                    <h2>Hizkuntza</h2>
                    <select name="hizkuntza">
                        <option value="eu" <?php echo ($xml->hizkuntza == 'eu') ? 'selected' : ''; ?>>Euskara</option>
                        <option value="es" <?php echo ($xml->hizkuntza == 'es') ? 'selected' : ''; ?>>Castellano</option>
                        <option value="en" <?php echo ($xml->hizkuntza == 'en') ? 'selected' : ''; ?>>English</option>
                    </select>
                </div>

                <div class="konfigurazioAukerak">
                    <h2>Koloreak</h2>
                    <div class="koloreaAukeratu">
                        <label>Menu Kolorea:
                            <input type="color" name="menuKolorea" value="<?php echo $xml->menuKolorea; ?>">
                        </label>
                        <label>Testu Kolorea:
                            <input type="color" name="textuKolorea" value="<?php echo $xml->textuKolorea; ?>">
                        </label>
                        <label>Atzeko Kolorea:
                            <input type="color" name="atzekaldeKolorea" value="<?php echo $xml->atzekaldeKolorea; ?>">
                        </label>
                    </div>
                </div>

                <div class="konfigurazioBotoiak">
                    <button type="submit" name="gorde">Gorde</button>
                    <button type="submit" name="berrezarri">Berrezarri</button>
                </div>
            </form>
        </div>
    </main>
    <?php require_once 'parts/footer.php'; ?>
</body>

</html>