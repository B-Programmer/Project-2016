<?php
if (empty($_SESSION['code'])) {
    ?>
    <div class="navbar" role="navigation">
        <div class="inner">

            <ul id="nav-main" class="linklist bulletin" role="menubar">


                <li class="small-icon icon-home breadcrumbs">
                    <span class="crumb" itemtype="#" itemscope=""><a href="?action=index" accesskey="h" data-navbar-reference="index" itemprop="url"><span itemprop="title">Board index</span></a></span>
                </li>
                <li class="small-icon icon-logout rightside"  data-skip-responsive="true"><a href="?action=login" title="Login" accesskey="x" role="menuitem">Login</a></li>
                <?php
                if ($_GET['action'] != 'register') {
                    echo '<li class="small-icon icon-register rightside" data-skip-responsive="true"><a href="?action=register" role="menuitem">Register</a></li>';
                }
                ?>
            </ul>

        </div>
    </div>
<?php } else { ?>

    <!--For Login-->
    <div class = "navbar" role = "navigation">
        <div class = "inner">

            <ul id = "nav-main" class = "linklist bulletin" role = "menubar">
                <li style = "max-width: 1125px;" class = "small-icon icon-home breadcrumbs">
                    <span class = "crumb" itemtype = "#" itemscope = ""><a title = "Board index" href = "./index.php" accesskey = "h" data-navbar-reference = "index" itemprop = "url"><span itemprop = "title">Board index</span></a></span>
                </li>
                <li id = "username_logged_in" class = "rightside " data-skip-responsive = "true">
                    <div class = "header-profile dropdown-container">
                        <a href = "#" class = "header-avatar dropdown-trigger dropdown-toggle"><span style = "color: #AA0000;" class = "username-coloured"><?php echo $_SESSION['code'] ?></span></a>
                        <div class = "dropdown hidden">
                            <div class = "pointer"><div class = "pointer-inner"></div></div>
                            <ul class = "dropdown-contents" role = "menu">
                                <li class = "small-icon icon-logout"><a href = "app/security/logout.php" title = "Logout" accesskey = "x" role = "menuitem">Logout</a></li>
                            </ul>
                        </div>
                    </div>
                </li>
            </ul>
        </div>
    </div>

<?php } ?>