<?php
/* Smarty version 3.1.30, created on 2016-10-02 14:45:11
  from "C:\VertrigoServ\www\ComputerScienceForum\administrator\app\views\post\edit.tpl" */

/* @var Smarty_Internal_Template $_smarty_tpl */
if ($_smarty_tpl->_decodeProperties($_smarty_tpl, array (
  'version' => '3.1.30',
  'unifunc' => 'content_57f11d77c9e060_57555886',
  'has_nocache_code' => false,
  'file_dependency' => 
  array (
    '0083362105a494b10cf4aabeb6ae689b53414234' => 
    array (
      0 => 'C:\\VertrigoServ\\www\\ComputerScienceForum\\administrator\\app\\views\\post\\edit.tpl',
      1 => 1475419493,
      2 => 'file',
    ),
  ),
  'includes' => 
  array (
  ),
),false)) {
function content_57f11d77c9e060_57555886 (Smarty_Internal_Template $_smarty_tpl) {
?>
<div class="breadcrumbs ace-save-state" id="breadcrumbs">
    <ul class="breadcrumb">
        <li>
            <i class="ace-icon fa fa-home home-icon"></i>
            <a href="#">Home</a>
        </li>

        <li>
            <a href="?controller=forum&action=index">Forums</a>
        </li>
        <li class="active">Edit</li>
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
                            <h3 class="header smaller lighter blue">Edit Forum</h3>

                            <div class="clearfix">
                                <div class="pull-left"><a href="?controller=forum&action=index" class="btn btn-danger" style="border: 2px"><strong class="fa fa-arrow-left">&nbsp;Return</strong></a></div>
                            </div>
                            
                            <form class="form-horizontal" role="form" action="?controller=post&action=update" method="POST">
                                <input type="hidden" name="id" value="<?php echo $_smarty_tpl->tpl_vars['post']->value->id;?>
" />
                                <div class="form-group">
                                    <label class="col-sm-3 control-label no-padding-right" for="form-field-1"> Select Forum </label>

                                    <div class="col-sm-9">
                                        <select name="forum_id" id="forum_id" onchange="loadTopic()" class="col-xs-10 col-sm-5">
                                            <option value="<?php echo $_smarty_tpl->tpl_vars['post']->value->forum_id;?>
"><?php echo $_smarty_tpl->tpl_vars['post']->value->forum_name;?>
</option>

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
                                            <option value="<?php echo $_smarty_tpl->tpl_vars['post']->value->topic_id;?>
"><?php echo $_smarty_tpl->tpl_vars['post']->value->subject;?>
</option>
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

                        </div>
                    </div>
                </div><!-- /.span -->
                <!-- PAGE CONTENT ENDS -->
            </div><!-- /.col -->
        </div><!-- /.row -->
    </div><!-- /.page-content --><?php }
}
