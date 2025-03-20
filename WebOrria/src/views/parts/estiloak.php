<?php
$xml = simplexml_load_file('../../config/settings.xml');
$menuKolorea = $xml->menuKolorea;
$textuKolorea = $xml->textuKolorea;
$atzekaldeKolorea = $xml->atzekaldeKolorea;
?>

<style>
:root {
    --menuKolorea: <?php echo $menuKolorea; ?>;
    --textuKolorea: <?php echo $textuKolorea; ?>;
    --atzekaldeKolorea: <?php echo $atzekaldeKolorea; ?>;
}
</style>