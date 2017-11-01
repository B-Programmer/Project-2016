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

    <?php
//    List of Forum
    require_once 'partials/listforum.php';
    ?>

    <!--User login-->
    <?php
    if (empty($_SESSION['code']) && empty($_SESSION['email'])) {
        ?>
        <form method="post" action="?action=user_login" class="headerspace">
            <h3><a href="?action=login">Login</a>&nbsp; &bull; &nbsp;<a href="?action=register">Register</a></h3>
            <fieldset class="quick-login">
                <label for="username"><span>Username:</span> <input type="text" tabindex="1" name="username" id="username" size="10" class="inputbox" title="Username" /></label>
                <label for="password"><span>Password:</span> <input type="password" tabindex="2" name="password" id="password" size="10" class="inputbox" title="Password" autocomplete="off" /></label>
                <input type="submit" tabindex="5" name="login" value="Login" class="button2" />

            </fieldset>
        </form>
    <?php } ?>


</div>