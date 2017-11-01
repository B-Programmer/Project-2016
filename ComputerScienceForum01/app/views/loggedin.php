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
                            <li class="small-icon icon-acp" data-last-responsive="true"><a href="http://localhost/forum/adm/index.php?sid=8a0c73662a7a31c6f2576e4cccef91ca" title="Administration Control Panel" role="menuitem">ACP</a></li>		<li class="small-icon icon-mcp" data-last-responsive="true"><a href="http://localhost/forum/mcp.php?i=main&amp;mode=front&amp;sid=8a0c73662a7a31c6f2576e4cccef91ca" title="Moderator Control Panel" role="menuitem">MCP</a></li>
                            <li id="username_logged_in" class="rightside " data-skip-responsive="true">
                                <div class="header-profile dropdown-container dropdown-left dropdown-down">
                                    <a href="http://localhost/forum/ucp.php" class="header-avatar dropdown-trigger dropdown-toggle"><span style="color: #AA0000;" class="username-coloured"><?php echo $_SESSION['code'] ?></span></a>
                                    <div style="display: none; margin-left: -1136px;" class="dropdown hidden">
                                        <div class="pointer"><div class="pointer-inner"></div></div>
                                        <ul style="margin-left: 0px; left: 0px; max-width: 1344px;" class="dropdown-contents dropdown-nonscroll" role="menu">


                                            <li class="small-icon icon-ucp"><a href="http://localhost/forum/ucp.php" title="User Control Panel" role="menuitem">User Control Panel</a></li>
                                            <li class="small-icon icon-profile"><a href="http://localhost/forum/memberlist.php?mode=viewprofile&amp;u=2" title="Profile" role="menuitem">Profile</a></li>


                                            <li class="separator"></li>
                                            <li class="small-icon icon-logout"><a href="http://localhost/forum/ucp.php?mode=logout&amp;sid=8a0c73662a7a31c6f2576e4cccef91ca" title="Logout" accesskey="x" role="menuitem">Logout</a></li>
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


                <p class="right responsive-center time rightside">Last visit was: Thu Sep 29, 2016 5:35 pm</p>
                <p class="responsive-center time">It is currently Fri Sep 30, 2016 11:02 am</p>
                <div class="action-bar compact">
                    <a href="http://localhost/forum/index.php?hash=bc25afbd&amp;mark=forums&amp;mark_time=1475233356" class="mark-read rightside" accesskey="m" data-ajax="mark_forums_read">Mark forums read</a>
                </div>



                <div class="forabg">
                    <div class="inner">
                        <ul class="topiclist">
                            <li class="header">
                                <dl class="icon">
                                    <dt><div class="list-inner"><a href="http://localhost/forum/viewforum.php?f=1">Your first category</a></div></dt>
                                    <dd class="topics">Topics</dd>
                                    <dd class="posts">Posts</dd>
                                    <dd class="lastpost"><span>Last post</span></dd>
                                </dl>
                            </li>
                        </ul>
                        <ul class="topiclist forums">





                            <li class="row">
                                <dl class="icon forum_read">
                                    <dt title="No unread posts">
                                    <div class="list-inner">
    <!-- <a class="feed-icon-forum" title="Feed - Your first forum" href="http://localhost/forum/feed.php?f=2"><img src="./styles/prosilver/theme/images/feed.gif" alt="Feed - Your first forum" /></a> -->
                                        <a href="http://localhost/forum/viewforum.php?f=2" class="forumtitle">Your first forum</a>
                                        <br>Description of your first forum.												
                                        <div class="responsive-show" style="display: none;">
                                            Topics: <strong>2</strong>
                                        </div>
                                    </div>
                                    </dt>
                                    <dd class="topics">2 <dfn>Topics</dfn></dd>
                                    <dd class="posts">4 <dfn>Posts</dfn></dd>
                                    <dd class="lastpost"><span>
                                            <dfn>Last post</dfn>
                                            <a href="http://localhost/forum/viewtopic.php?f=2&amp;p=4#p4" title="Re: Welcome to phpBB3" class="lastsubject">Re: Welcome to phpBB3</a> <br>

                                            by <a href="http://localhost/forum/memberlist.php?mode=viewprofile&amp;u=2" style="color: #AA0000;" class="username-coloured"><?php echo $_SESSION['code'] ?></a>
                                            <a href="http://localhost/forum/viewtopic.php?f=2&amp;p=4#p4"><span class="imageset icon_topic_latest" title="View the latest post">View the latest post</span></a> <br>Fri Sep 30, 2016 10:59 am</span>
                                    </dd>
                                </dl>
                            </li>

                        </ul>

                    </div>
                </div>





                <div class="stat-block online-list">
                    <h3><a href="http://localhost/forum/viewonline.php">Who is online</a></h3>		<p>
                        In total there is <strong>1</strong> user online :: 1 registered, 0 hidden and 0 guests (based on users active over the past 5 minutes)<br>Most users ever online was <strong>2</strong> on Thu Sep 29, 2016 5:35 pm<br> <br>Registered users: <a href="http://localhost/forum/memberlist.php?mode=viewprofile&amp;u=2" style="color: #AA0000;" class="username-coloured"><?php echo $_SESSION['code'] ?></a>
                        <br><em>Legend: <a style="color:#AA0000" href="http://localhost/forum/memberlist.php?mode=group&amp;g=5"><?php echo $_SESSION['code'] ?>s</a>, <a style="color:#00AA00" href="http://localhost/forum/memberlist.php?mode=group&amp;g=4">Global moderators</a></em>					</p>
                </div>

                <div class="stat-block birthday-list">
                    <h3>Birthdays</h3>
                    <p>
                        No birthdays today					</p>
                </div>

                <div class="stat-block statistics">
                    <h3>Statistics</h3>
                    <p>
                        Total posts <strong>4</strong> • Total topics <strong>2</strong> • Total members <strong>1</strong> • Our newest member <strong><a href="http://localhost/forum/memberlist.php?mode=viewprofile&amp;u=2" style="color: #AA0000;" class="username-coloured"><?php echo $_SESSION['code'] ?></a></strong>
                    </p>
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
                    <br><strong><a href="http://localhost/forum/adm/index.php?sid=8a0c73662a7a31c6f2576e4cccef91ca">Administration Control Panel</a></strong>	</div>

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
