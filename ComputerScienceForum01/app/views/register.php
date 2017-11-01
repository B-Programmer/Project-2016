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

    <form id="register" method="post" action="?action=user_register">

        <div class="panel">
            <div class="inner">

                <h2>yourdomain.com - Registration</h2>

                <fieldset class="fields2">
                    <dl>
                        <dt><label for="username">Username:</label><br><span>Length must be between 3 characters and 20 characters.</span></dt>
                        <dd><input tabindex="1" name="username" id="username" size="25" class="inputbox autowidth" title="Username" type="text"></dd>
                    </dl>
                    <dl>
                        <dt><label for="email">Email address:</label></dt>
                        <dd><input tabindex="2" name="email" id="email" size="25" maxlength="100" class="inputbox autowidth" title="Email address" autocomplete="off" type="email"></dd>
                    </dl>
                    <dl>
                        <dt><label for="new_password">Password:</label><br><span>Must be between 6 characters and 100 characters.</span></dt>
                        <dd><input tabindex="4" name="new_password" id="new_password" size="25" value="" class="inputbox autowidth" title="New password" autocomplete="off" type="password"></dd>
                    </dl>
                    <dl>
                        <dt><label for="password_confirm">Confirm password:</label></dt>
                        <dd><input tabindex="5" name="password_confirm" id="password_confirm" size="25" value="" class="inputbox autowidth" title="Confirm password" autocomplete="off" type="password"></dd>
                    </dl>

                </fieldset>
            </div>
        </div>


        <div class="panel">
            <div class="inner">

                <fieldset class="submit-buttons">
                    <input value="Reset" name="reset" class="button2" type="reset">&nbsp;
                    <input tabindex="9" name="submit" id="submit" value="Submit" class="button1 default-submit-action" type="submit">
                </fieldset>

            </div>
        </div>
    </form>

</div>