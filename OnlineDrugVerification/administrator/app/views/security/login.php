<!DOCTYPE html>
<html lang="en">
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <!-- Meta, title, CSS, favicons, etc. -->
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">

        <title>Login | Drug Verification System</title>

        <!-- Bootstrap -->
        <link href="../public/vendors/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet">
        <!-- Font Awesome -->
        <link href="../public/vendors/font-awesome/css/font-awesome.min.css" rel="stylesheet">

        <!-- Custom Theme Style -->
        <link href="../public/css/custom.css" rel="stylesheet">

        <!-- jQuery -->
        <script src="../public/vendors/jquery/dist/jquery.min.js"></script>
        <!-- Bootstrap JS-->
        <script src="../public/vendors/bootstrap/dist/js/bootstrap.min.js"></script>
    </head>

    <body style="background:#F7F7F7;">
        <div class="">

            <div id="wrapper">
                <div id="login" class=" form">
                    <section class="login_content">
                        <?php
                        if (!empty($_GET['errorCode']) && $_GET['errorCode'] == 1) {
                            ?>
                            <div class="alert alert-danger alert-dismissible" role="alert">
                                <button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                <strong>Error</strong> Username Or Password Incorrect.
                            </div>
                        <?php } ?>
                        <form method="post" action="app/security/login.php">
                            <h1>Login Form</h1>
                            <div>
                                <input type="text" class="form-control" name="username" placeholder="Username" required="" />
                            </div>
                            <div>
                                <input type="password" class="form-control" name="password" placeholder="Password" required="" />
                            </div>
                            <div>
                                <button type="submit" class="btn btn-dark btn-block">Log in</button>
                            </div>
                            <div class="clearfix"></div>
                            <div class="separator">

                                <div class="clearfix"></div>
                                <br />
                                <div>
                                    <h1><i class="fa fa-industry" style="font-size: 26px;"></i> Drug Verification System</h1>

                                    <p>&copy; <?php echo date('Y'); ?> All Rights Reserved.</p>
                                </div>
                            </div>
                        </form>
                    </section>
                </div>
            </div>
        </div>
    </body>
</html>