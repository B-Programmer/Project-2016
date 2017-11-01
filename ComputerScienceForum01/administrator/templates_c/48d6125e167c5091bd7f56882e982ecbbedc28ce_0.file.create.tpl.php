<?php
/* Smarty version 3.1.30, created on 2016-10-02 12:40:34
  from "C:\VertrigoServ\www\ComputerScienceForum\administrator\app\views\post\create.tpl" */

/* @var Smarty_Internal_Template $_smarty_tpl */
if ($_smarty_tpl->_decodeProperties($_smarty_tpl, array (
  'version' => '3.1.30',
  'unifunc' => 'content_57f10042221d76_59278290',
  'has_nocache_code' => false,
  'file_dependency' => 
  array (
    '48d6125e167c5091bd7f56882e982ecbbedc28ce' => 
    array (
      0 => 'C:\\VertrigoServ\\www\\ComputerScienceForum\\administrator\\app\\views\\post\\create.tpl',
      1 => 1475412029,
      2 => 'file',
    ),
  ),
  'includes' => 
  array (
  ),
),false)) {
function content_57f10042221d76_59278290 (Smarty_Internal_Template $_smarty_tpl) {
?>
<div class="breadcrumbs ace-save-state" id="breadcrumbs">
    <ul class="breadcrumb">
        <li>
            <i class="ace-icon fa fa-home home-icon"></i>
            <a href="#">Home</a>
        </li>

        <li>
            <a href="?controller=post&action=index">Post</a>
        </li>
        <li class="active">Create Post</li>
    </ul><!-- /.breadcrumb -->

    <div class="nav-search" id="nav-search">
        <form class="form-search">
            <span class="input-icon">
                <input type="text" placeholder="Search ..." class="nav-search-input" id="nav-search-input" autocomplete="off" />
                <i class="ace-icon fa fa-search nav-search-icon"></i>
            </span>
        </form>
    </div><!-- /.nav-search -->
</div>

<div class="page-content">

    <div class="row">
        <div class="col-xs-12">
            <!-- PAGE CONTENT BEGINS -->
            <div class="row">
                <div class="col-xs-12">
                    <div class="row">
                        <div class="col-xs-12">
                            <h3 class="header smaller lighter blue">Create New Post</h3>

                            <div class="clearfix">
                                <div class="pull-left"><a href="?controller=post&action=index" class="btn btn-danger" style="border: 2px"><strong class="fa fa-arrow-left">&nbsp;Return</strong></a></div>
                            </div>

                            <!-- div.table-responsive -->
                            <form class="form-horizontal" role="form" action="?controller=post&action=store" method="POST">

                                <div class="form-group">
                                    <label class="col-sm-3 control-label no-padding-right" for="form-field-1"> Select Forum </label>

                                    <div class="col-sm-9">
                                        <select name="forum_id" id="forum_id" onchange="loadTopic()" class="col-xs-10 col-sm-5">
                                            <option>--- Select Below ---</option>

                                            <?php
$_from = $_smarty_tpl->smarty->ext->_foreach->init($_smarty_tpl, $_smarty_tpl->tpl_vars['forums']->value, 'forum');
if ($_from !== null) {
foreach ($_from as $_smarty_tpl->tpl_vars['forum']->value) {
?>
                                                <option value="<?php echo $_smarty_tpl->tpl_vars['forum']->value->id;?>
"><?php echo $_smarty_tpl->tpl_vars['forum']->value->forum_name;?>
</option>
                                            <?php
}
}
$_smarty_tpl->smarty->ext->_foreach->restore($_smarty_tpl);
?>

                                        </select>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="col-sm-3 control-label no-padding-right" for="form-field-1"> Select Topic </label>

                                    <div class="col-sm-9">
                                        <select name="topic_id" id="topic_id" onchange="loadPost()" class="col-xs-10 col-sm-5">
                                        </select>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="col-sm-3 control-label no-padding-right" for="form-field-1"> Select Reply Post </label>

                                    <div class="col-sm-9">
                                        <select name="reply_id" id="reply_id" class="col-xs-10 col-sm-5">
                                        </select>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="col-sm-3 control-label no-padding-right" for="form-field-1"> Post</label>

                                    <div class="col-sm-9">
                                        <textarea name="post" class="col-xs-10 col-sm-5" id="form-field-1" placeholder="My Post"></textarea>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label no-padding-right" for="form-field-1"></label>

                                    <div class="col-sm-9">
                                        <button id="create-post" class="btn btn-white btn-info btn-bold col-xs-10 col-sm-5">
                                            <i class="ace-icon fa fa-floppy-o bigger-120 blue"></i>
                                            Create
                                        </button>
                                    </div>
                                </div>

                            </form>
                            <!-- div.dataTables_borderWrap -->

                        </div>
                    </div>
                </div><!-- /.span -->
                <!-- PAGE CONTENT ENDS -->
            </div><!-- /.col -->
        </div><!-- /.row -->
    </div><!-- /.page-content --><?php }
}
