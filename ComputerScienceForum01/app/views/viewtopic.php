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


    <h2 class="topic-title"><a href="#"><?php echo $topic->subject ?></a></h2>
    <!-- NOTE: remove the style="display: none" when you want to have the forum description on the topic body -->
    <div style="display: none !important;">Description of your first forum.<br /></div>


    <div class="action-bar top">

        <div class="buttons">

            <a href="?action=new_reply&forum_id=<?php echo $_GET['forum_id'] ?>&topic_id=<?php echo $_GET['topic_id'] ?>" class="button icon-button reply-icon" title="Post a reply">Post Reply</a>

        </div>

    </div>

    <?php require_once 'partials/listposts.php'; ?>

    <hr class="divider" />



    <div class="action-bar bottom">
        <div class="buttons">

            <a href="?action=new_reply&forum_id=<?php echo $_GET['forum_id'] ?>&topic_id=<?php echo $_GET['topic_id'] ?>" class="button icon-button reply-icon" title="Post a reply">Post Reply</a>
        </div>

    </div>

    <p class="jumpbox-return"><a href="index.php" class="left-box arrow-left" accesskey="r">Return to “Your first forum”</a></p>

</div>