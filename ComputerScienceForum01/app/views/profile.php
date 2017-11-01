<!DOCTYPE html>
<html dir="ltr" lang="en-gb">

    <?php require_once 'partials/head.php'; ?>

    <body id="phpbb" class="hasjs notouch section-index ltr ">

        <div id="wrap">
            <a id="top" class="anchor" accesskey="t"></a>
            <div id="page-header">
                <div class="headerbar" role="banner">
                    <div class="inner">

                        <div id="site-description">
                            <a id="logo" class="logo" href="http://localhost/forum/index.php" title="Board index"><span class="imageset site_logo"></span></a>
                            <h1>yourdomain.com</h1>
                            <p>A short text to describe your forum</p>
                            <p class="skiplink"><a href="#start_here">Skip to content</a></p>
                        </div>

                        <div id="search-box" class="search-box search-header" role="search">
                            <form action="./search.php" method="get" id="search">
                                <fieldset>
                                    <input name="keywords" id="keywords" maxlength="128" title="Search for keywords" class="inputbox search tiny" size="20" placeholder="Search…" type="search">
                                    <button class="button icon-button search-icon" type="submit" title="Search">Search</button>
                                    <a href="http://localhost/forum/search.php" class="button icon-button search-adv-icon" title="Advanced search">Advanced search</a>

                                </fieldset>
                            </form>
                        </div>

                    </div>
                </div>
                <div class="navbar" role="navigation">
                    <div class="inner">

                        <ul id="nav-main" class="linklist bulletin" role="menubar">

                            <li id="quick-links" class="small-icon responsive-menu dropdown-container" data-skip-responsive="true">
                                <a href="#" class="responsive-menu-link dropdown-trigger dropdown-toggle">Quick links</a>
                                <div class="dropdown hidden">
                                    <div class="pointer"><div class="pointer-inner"></div></div>
                                    <ul class="dropdown-contents" role="menu">

                                        <li class="separator"></li>
                                        <li class="small-icon icon-search-self"><a href="http://localhost/forum/search.php?search_id=egosearch" role="menuitem">Your posts</a></li>
                                        <li class="small-icon icon-search-new"><a href="http://localhost/forum/search.php?search_id=newposts" role="menuitem">New posts</a></li>

                                        <li class="small-icon icon-search-unread"><a href="http://localhost/forum/search.php?search_id=unreadposts" role="menuitem">Unread posts</a></li>
                                        <li class="small-icon icon-search-unanswered"><a href="http://localhost/forum/search.php?search_id=unanswered" role="menuitem">Unanswered topics</a></li>
                                        <li class="small-icon icon-search-active"><a href="http://localhost/forum/search.php?search_id=active_topics" role="menuitem">Active topics</a></li>
                                        <li class="separator"></li>
                                        <li class="small-icon icon-search"><a href="http://localhost/forum/search.php" role="menuitem">Search</a></li>

                                        <li class="separator"></li>
                                        <li class="small-icon icon-members"><a href="http://localhost/forum/memberlist.php" role="menuitem">Members</a></li>						<li class="small-icon icon-team"><a href="http://localhost/forum/memberlist.php?mode=team" role="menuitem">The team</a></li>										<li class="separator"></li>

                                    </ul>
                                </div>
                            </li>

                            <li class="small-icon icon-faq" data-last-responsive="true"><a href="http://localhost/forum/faq.php" rel="help" title="Frequently Asked Questions" role="menuitem">FAQ</a></li>
                            <li class="small-icon icon-acp" data-last-responsive="true"><a href="http://localhost/forum/adm/index.php?sid=42faaa7d0289a2d9f2901f322b92a8f4" title="Administration Control Panel" role="menuitem">ACP</a></li>		
                            <li id="username_logged_in" class="rightside " data-skip-responsive="true">
                                <div class="header-profile dropdown-container">
                                    <a href="http://localhost/forum/ucp.php" class="header-avatar dropdown-trigger dropdown-toggle"><span style="color: #AA0000;" class="username-coloured"><?php echo $_SESSION['code'] ?></span></a>
                                    <div class="dropdown hidden">
                                        <div class="pointer"><div class="pointer-inner"></div></div>
                                        <ul class="dropdown-contents" role="menu">


                                            <li class="small-icon icon-ucp"><a href="http://localhost/forum/ucp.php" title="User Control Panel" role="menuitem">User Control Panel</a></li>
                                            <li class="small-icon icon-profile"><a href="http://localhost/forum/memberlist.php?mode=viewprofile&amp;u=2" title="Profile" role="menuitem">Profile</a></li>


                                            <li class="separator"></li>
                                            <li class="small-icon icon-logout"><a href="http://localhost/forum/ucp.php?mode=logout&amp;sid=42faaa7d0289a2d9f2901f322b92a8f4" title="Logout" accesskey="x" role="menuitem">Logout</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </li>
                            <li class="small-icon icon-pm rightside" data-skip-responsive="true">
                                <a href="http://localhost/forum/ucp.php?i=pm&amp;folder=inbox" role="menuitem"><span>Private messages [</span><strong>0</strong><span>]</span></a>
                            </li>
                            <li class="small-icon icon-notification dropdown-container dropdown-right rightside" data-skip-responsive="true">
                                <a href="http://localhost/forum/ucp.php?i=ucp_notifications" id="notification_list_button" class="dropdown-trigger dropdown-toggle"><span>Notifications [</span><strong>0</strong><span>]</span></a>
                                <div id="notification_list" class="dropdown dropdown-extended notification_list">
                                    <div class="pointer"><div class="pointer-inner"></div></div>
                                    <div class="dropdown-contents">
                                        <div class="header">
                                            Notifications
                                            <span class="header_settings">
                                                <a href="http://localhost/forum/ucp.php?i=ucp_notifications&amp;mode=notification_options">Settings</a>
                                            </span>
                                        </div>

                                        <ul>
                                            <li class="no_notifications">
                                                You have no notifications
                                            </li>
                                        </ul>

                                        <div class="footer">
                                            <a href="http://localhost/forum/ucp.php?i=ucp_notifications"><span>See All</span></a>
                                        </div>
                                    </div>
                                </div>
                            </li>
                        </ul>

                        <ul id="nav-breadcrumbs" class="linklist navlinks" role="menubar">
                            <li style="max-width: 1125px;" class="small-icon icon-home breadcrumbs">
                                <span class="crumb" itemtype="http://data-vocabulary.org/Breadcrumb" itemscope=""><a title="Board index" href="http://localhost/forum/index.php" accesskey="h" data-navbar-reference="index" itemprop="url"><span itemprop="title">Board index</span></a></span>
                            </li>

                            <li class="rightside responsive-search" style="display: none;"><a href="http://localhost/forum/search.php" title="View the advanced search options" role="menuitem">Search</a></li>
                        </ul>

                    </div>
                </div>
            </div>


            <a id="start_here" class="anchor"></a>
            <div id="page-body" role="main">


                <h2 class="memberlist-title">Viewing profile - <?php echo $_SESSION['code'] ?></h2>


                <form method="post" action="./memberlist.php?mode=group" id="viewprofile">
                    <div class="panel bg1 online">
                        <div class="inner">


                            <dl class="left-box details profile-details">
                                <dt>Username:</dt>
                                <dd>
                                    <span style="color: #AA0000; font-weight: bold;"><?php echo $_SESSION['code'] ?></span>
                                    [ <a href="http://localhost/forum/ucp.php?i=ucp_profile&amp;mode=profile_info">Edit profile</a> ]			 [ <a href="http://localhost/forum/adm/index.php?i=users&amp;mode=overview&amp;u=2&amp;sid=42faaa7d0289a2d9f2901f322b92a8f4">Administer user</a> ]								</dd>
                                <dt>Rank:</dt> <dd>Site Admin</dd>														<dt>Groups:</dt> <dd><select name="g"><option value="5" selected="selected"><?php echo $_SESSION['code'] ?>s</option><option value="4">Global moderators</option><option value="2">Registered users</option></select> <input name="submit" value="Go" class="button2" type="submit"></dd>													</dl>

                        </div>
                    </div>

                    <div class="panel bg2">
                        <div class="inner">

                            <div class="column1">
                                <h3>Contact <?php echo $_SESSION['code'] ?></h3>

                                <dl class="details">
                                    <dt>Email address:</dt> <dd><a href="mailto:admin@admin.com">Send email to <?php echo $_SESSION['code'] ?></a></dd>		<dt>PM:</dt> <dd><a href="http://localhost/forum/ucp.php?i=pm&amp;mode=compose&amp;u=2">Send private message</a></dd>												</dl>
                            </div>

                            <div class="column2">
                                <h3>User statistics</h3>
                                <dl class="details">
                                    <dt>Joined:</dt> <dd>Thu Sep 29, 2016 5:32 pm</dd>
                                    <dt>Last active:</dt> <dd>Fri Sep 30, 2016 11:16 am</dd>
                                    <dt>Warnings: </dt>
                                    <dd><strong>0</strong> [ <a href="http://localhost/forum/mcp.php?i=notes&amp;mode=user_notes&amp;u=2&amp;sid=42faaa7d0289a2d9f2901f322b92a8f4">View user notes</a>  | <a href="http://localhost/forum/mcp.php?i=warn&amp;mode=warn_user&amp;u=2&amp;sid=42faaa7d0289a2d9f2901f322b92a8f4">Warn user</a> ]</dd>
                                    <dt>Total posts:</dt>
                                    <dd>4 | <strong><a href="http://localhost/forum/search.php?author_id=2&amp;sr=posts">Search user’s posts</a></strong>					<br>(100.00% of all posts / 4.00 posts per day)									</dd>
                                    <dt>Most active forum:</dt> <dd><strong><a href="http://localhost/forum/viewforum.php?f=2">Your first forum</a></strong><br>(4 Posts / 100.00% of your posts)</dd>
                                    <dt>Most active topic:</dt> <dd><strong><a href="http://localhost/forum/viewtopic.php?t=1">Welcome to phpBB3</a></strong><br>(2 Posts / 50.00% of your posts)</dd>
                                </dl>
                            </div>

                        </div>
                    </div>


                </form>





                <div class="dropdown-container dropdown-container-right dropdown-up dropdown-left dropdown-button-control" id="jumpbox">
                    <span title="Jump to" class="dropdown-trigger button dropdown-select dropdown-toggle">
                        Jump to		</span>
                    <div class="dropdown hidden">
                        <div class="pointer"><div class="pointer-inner"></div></div>
                        <ul class="dropdown-contents">
                            <li><a href="http://localhost/forum/viewforum.php?f=1">Your first category</a></li>
                            <li>&nbsp; &nbsp;<a href="http://localhost/forum/viewforum.php?f=2">Your first forum</a></li>
                        </ul>
                    </div>
                </div>


            </div>


            <div id="page-footer" role="contentinfo">
                <div class="navbar" role="navigation">
                    <div class="inner">

                        <ul id="nav-footer" class="linklist bulletin" role="menubar">
                            <li class="small-icon icon-home breadcrumbs">
                                <span class="crumb"><a title="Board index" href="http://localhost/forum/index.php" data-navbar-reference="index">Board index</a></span>
                            </li>

                            <li class="responsive-menu hidden rightside dropdown-container"><a href="javascript:void(0);" class="responsive-menu-link dropdown-toggle">&nbsp;</a><div class="dropdown hidden"><div class="pointer"><div class="pointer-inner"></div></div><ul class="dropdown-contents"></ul></div></li><li class="rightside">All times are <abbr title="UTC">UTC</abbr></li>
                            <li class="small-icon icon-delete-cookies rightside"><a href="http://localhost/forum/ucp.php?mode=delete_cookies" data-ajax="true" data-refresh="true" role="menuitem">Delete all board cookies</a></li>
                            <li class="small-icon icon-members rightside" data-last-responsive="true"><a href="http://localhost/forum/memberlist.php" title="View complete list of members" role="menuitem">Members</a></li>						<li class="small-icon icon-team rightside" data-last-responsive="true"><a href="http://localhost/forum/memberlist.php?mode=team" role="menuitem">The team</a></li>					</ul>

                    </div>
                </div>

                <div class="copyright">
                    Powered by <a href="https://www.phpbb.com/">phpBB</a>® Forum Software © phpBB Limited
                    <br><strong><a href="http://localhost/forum/adm/index.php?sid=42faaa7d0289a2d9f2901f322b92a8f4">Administration Control Panel</a></strong>	</div>

                <div id="darkenwrapper" data-ajax-error-title="AJAX error" data-ajax-error-text="Something went wrong when processing your request." data-ajax-error-text-abort="User aborted request." data-ajax-error-text-timeout="Your request timed out; please try again." data-ajax-error-text-parsererror="Something went wrong with the request and the server returned an invalid reply.">
                    <div id="darken">&nbsp;</div>
                </div>

                <div id="phpbb_alert" class="phpbb_alert" data-l-err="Error" data-l-timeout-processing-req="Request timed out.">
                    <a href="#" class="alert_close"></a>
                    <h3 class="alert_title">&nbsp;</h3><p class="alert_text"></p>
                </div>
                <div id="phpbb_confirm" class="phpbb_alert">
                    <a href="#" class="alert_close"></a>
                    <div class="alert_text"></div>
                </div>
            </div>

        </div>

        <?php require_once 'partials/footer.php'; ?>


    </body>

    <!-- Mirrored from localhost/forum/ by HTTrack Website Copier/3.x [XR&CO'2014], Fri, 30 Sep 2016 06:19:28 GMT -->
</html>
