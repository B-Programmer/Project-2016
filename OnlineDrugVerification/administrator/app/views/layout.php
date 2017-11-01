<!DOCTYPE html>
<html lang="en">
    <head>
        <!--Head Properties-->
        <?php require_once 'app/views/partials/header.php'; ?>

        <title> Web Based Herbal Drug Verification System </title>

        <!-- Styles Here -->
        <?php require_once 'app/views/partials/styles.php'; ?>

    </head>

    <body class="nav-md">
        <div class="container body">
            <div class="main_container">
                <div class="col-md-3 left_col">
                    <div class="left_col scroll-view">
                        <div class="navbar nav_title" style="border: 0;">
                            <a href="?controller=drug&action=index" class="site_title"><i class="fa fa-industry"></i> <span>cPanel</span></a>
                        </div>

                        <div class="clearfix"></div>

                        <!-- menu profile quick info -->
                        <?php require_once 'app/views/partials/menu_profile.php'; ?>
                        <!-- /menu profile quick info -->

                        <br />

                        <!-- sidebar menu -->
                        <?php require_once 'app/views/partials/side_menu.php'; ?>
                        <!-- /sidebar menu -->

                        <!-- /menu footer buttons -->
                        <?php require_once 'app/views/partials/menu_footer.php'; ?>
                        <!-- /menu footer buttons -->
                    </div>
                </div>

                <!-- top navigation -->
                <?php require_once 'app/views/partials/top_menu.php'; ?>
                <!-- /top navigation -->


                <!-- page content -->
                <?php require_once 'app/routes.php'; ?>
                <!-- /page content -->

                <!-- footer content -->
                <?php require_once 'app/views/partials/footer.php'; ?>
                <!-- /footer content -->
            </div>
        </div>

        <?php require_once 'app/views/partials/scripts.php'; ?>
    </body>
</html>s