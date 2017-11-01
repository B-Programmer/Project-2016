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
    <h2 class="forum-title"><a href="?action=viewforum&forum_id=<?php echo $forum->id ?>"><?php echo $forum->forum_desc ?></a></h2>

    <div class="action-bar top">

        <div class="buttons">

            <a href="?action=new_topic&forum_id=<?php echo $forum->id ?>" class="button icon-button post-icon" title="Post a new topic">New Topic</a>

        </div>

    </div>

    <?php require_once 'partials/listtopics.php'; ?>


    <div class="action-bar bottom">
        <div class="buttons">

            <a href="?action=new_topic&forum_id=<?php echo $forum->id ?>" class="button icon-button post-icon" title="Post a new topic">New Topic</a>

        </div>
    </div>


    <p class="jumpbox-return"><a href="index.php" class="left-box arrow-left" accesskey="r">Return to Board Index</a></p>

</div>
