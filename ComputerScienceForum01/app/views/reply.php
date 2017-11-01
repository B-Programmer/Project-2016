<?php require_once 'partials/navbar.php'; ?>

<br>
<!--Display with login-->
<?php
if (!empty($_SESSION['code'])) {
    echo '<p class = "right responsive-center time rightside">Last visit was: ' . date("D M d, Y h:i a") . '</p>';
}
?>
<!--Without login-->
<p class="responsive-center time">It is currently <?php echo date("D M d, Y h:i a"); ?></p>

</div>

<a id="start_here" class="anchor"></a>
<div id="page-body" role="main">

    <?php if ($_GET['action'] == 'new_topic') { ?>
        <h2 class="posting-title"><a href="?action=viewforum&forum_id=<?php echo $forum->id ?>"><?php echo $forum->forum_name ?></a></h2>

        <?php require_once 'app/views/partials/newtopic.php'; ?>
        
    <?php } else if ($_GET['action'] == 'new_reply') { ?>
        
        <h2 class="posting-title"><a href="?action="></a><?php echo $topic->subject ?></h2>

        <?php require_once 'app/views/partials/newreply.php'; ?>
    <?php } ?>

</div>
