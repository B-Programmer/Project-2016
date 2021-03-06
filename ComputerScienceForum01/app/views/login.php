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


    <form action="?action=user_login" method="post" id="login" data-focus="username">
        <div class="panel">
            <div class="inner">

                <div class="content">
                    <h2 class="login-title">You need to login in order to reply to topics within this forum.</h2>

                    <fieldset class="fields1">
                        <dl>
                            <dt><label for="username">Username:</label></dt>
                            <dd><input type="text" tabindex="1" name="username" id="username" size="25" value="" class="inputbox autowidth" /></dd>
                        </dl>
                        <dl>
                            <dt><label for="password">Password:</label></dt>
                            <dd><input type="password" tabindex="2" id="password" name="password" size="25" class="inputbox autowidth" autocomplete="off" /></dd>
                        </dl>

                        <dl>
                            <dt>&nbsp;</dt>
                            <dd>
                                <input type="submit" name="login" tabindex="6" value="Login" class="button1" /></dd>
                        </dl>
                    </fieldset>
                </div>

            </div>
        </div>


        <div class="panel">
            <div class="inner">

                <div class="content">
                    <h3>Register</h3>
                    <p>In order to login you must be registered. Registering takes only a few moments but gives you increased capabilities. Please ensure you read any forum rules as you navigate around the board.</p>
                    <hr class="dashed" />
                    <p><a href="?action=register" class="button2">Register</a></p>
                </div>

            </div>
        </div>

    </form>

</div>