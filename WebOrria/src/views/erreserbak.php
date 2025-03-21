<?php
require_once("db.php");

$conn = konexioaSortu();

if (isset($_POST["erreserbaEginBTN"])) {
    $idenfitikadorea = $_POST["identifikadorea"];
    $pasahitza = $_POST["pasahitza"];
    $data = $_POST["data"];
    $eremua = $_POST["eremua"];


    $sql = "SELECT * FROM bazkidea WHERE identifikadorea = '$idenfitikadorea' AND pasahitza = '$pasahitza'";

    $result = $conn->query($sql);
    if ($result->num_rows == 0) {
        $sql = "SELECT * FROM kluba WHERE identifikadorea = '$idenfitikadorea' AND pasahitza = '$pasahitza'";
        $result = $conn->query($sql);
        if ($result->num_rows == 0) {
            echo "Erabiltzaile edo pasahitza ez da zuzena.";
        } else { 
            $sql = "INSERT INTO erreserba (idEremua, idKluba, erreserbaEguna) VALUES ('$eremua', '$idenfitikadorea', '$data')";
            if ($conn->query($sql) === TRUE) {
                echo "Erreserba ongi gorde da.";
            } else {
                echo "Errorea: " . $conn->error;
            }
        }
    } else {
        $sql = "INSERT INTO erreserba (idEremua, idBazkidea, erreserbaEguna) VALUES ('$eremua', '$idenfitikadorea', '$data')";
        if ($conn->query($sql) === TRUE) {
            echo "Erreserba ongi gorde da.";
        } else {
            echo "Errorea: " . $conn->error;
        }
    }
            

}
?>
<!DOCTYPE html>
<html>
    <head>
        <link rel="stylesheet" type="text/css" href="../../public/css/css.css">
        <title>Erreserbak</title>
    </head>
    <body class="main-grid">
        <?php require_once 'parts/header.php'; ?>
        <main>
            <div class="erreserbaFormularioaKontainer">
                <h2>Erreserba Berria</h2>
                <form method="post" action="" class="erreserbaFormularioa">
                    <div class="formularioa">
                        <label for="identifikadorea">Bazkide/Klub identifikadorea:</label>
                        <input type="text" id="identifikadorea" name="identifikadorea" required placeholder="B-XXXX | K-XXXX">
                    </div>

                    <div class="formularioa">
                        <label for="pasahitza">Pasahitza:</label>
                        <input type="password" id="pasahitza" name="pasahitza" required>
                    </div>

                    <div class="formularioa">
                        <label for="data">Data:</label>
                        <input type="date" id="data" name="data" required>
                    </div>

                    <div class="formularioa">
                        <label for="eremua">Eremua:</label>
                        <select id="eremua" name="eremua" required>
                            <option value="">Aukeratu eremua</option>
                            <option value="1">Gimnasioa</option>
                            <option value="2">Futbol zelaia</option>
                            <option value="3">Igerileku estalia</option>
                            <option value="4">Tenis zelaia</option>
                            <option value="5">Eskubaloi pista</option>
                            <option value="6">Saskibaloi pista</option>
                            <option value="7">Atletismo pista</option>
                            <option value="8">Kanpoko eskubaloi pista</option>
                            <option value="9">Kanpoko saskibaloi pista</option>

                        </select>
                    </div>

                    <button type="submit" class="erreserbaEginBTN">Erreserba Egin</button>
                </form>
            </div>
        </main>
        <?php require_once 'parts/footer.php'; ?>
    </body>
</html>