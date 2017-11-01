<?php
/* Smarty version 3.1.30, created on 2016-10-01 19:50:33
  from "C:\VertrigoServ\www\ComputerScienceForum\administrator\app\views\topic\edit.tpl" */

/* @var Smarty_Internal_Template $_smarty_tpl */
if ($_smarty_tpl->_decodeProperties($_smarty_tpl, array (
  'version' => '3.1.30',
  'unifunc' => 'content_57f01389dc7194_84123422',
  'has_nocache_code' => false,
  'file_dependency' => 
  array (
    '1cf3613723d86347af9b4902c42d54c5eeae0dd6' => 
    array (
      0 => 'C:\\VertrigoServ\\www\\ComputerScienceForum\\administrator\\app\\views\\topic\\edit.tpl',
      1 => 1475351381,
      2 => 'file',
    ),
  ),
  'includes' => 
  array (
  ),
),false)) {
function content_57f01389dc7194_84123422 (Smarty_Internal_Template $_smarty_tpl) {
?>
<div class="breadcrumbs ace-save-state" id="breadcrumbs">
    <ul class="breadcrumb">
        <li>
            <i class="ace-icon fa fa-home home-icon"></i>
            <a href="#">Home</a>
        </li>

        <li>
            <a href="?controller=topic&action=index">Forums</a>
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
                                <div class="pull-left"><a href="?controller=topic&action=index" class="btn btn-danger" style="border: 2px"><strong class="fa fa-arrow-left">&nbsp;Return</strong></a></div>
                            </div>

                            <!-- div.table-responsive -->
                            <form class="form-horizontal" role="form" action="?controller=topic&action=update" method="POST">

                                <input type="hidden" value="<?php echo $_smarty_tpl->tpl_vars['topic']->value->id;?>
" name="id" />

                                <div class="form-group">
                                    <label class="col-sm-3 control-label no-padding-right" for="form-field-1"> Select Forum </label>

                                    <div class="col-sm-9">
                                        <select name="forum_id" class="col-xs-10 col-sm-5">
                                            <?php
$_from = $_smarty_tpl->smarty->ext->_foreach->init($_smarty_tpl, $_smarty_tpl->tpl_vars['forums']->value, 'forum');
if ($_from !== null) {
foreach ($_from as $_smarty_tpl->tpl_vars['forum']->value) {
?>
                                                <?php if ($_smarty_tpl->tpl_vars['topic']->value->id == $_smarty_tpl->tpl_vars['forum']->value->id) {?>
                                                    <option value="<?php echo $_smarty_tpl->tpl_vars['topic']->value->id;?>
"><?php echo $_smarty_tpl->tpl_vars['forum']->value->forum_name;?>
</option>
                                                <?php }?>
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
                                    <label class="col-sm-3 control-label no-padding-right" for="form-field-1"> Forum Name </label>

                                    <div class="col-sm-9">
                                        <input name="subject" value="<?php echo $_smarty_tpl->tpl_vars['topic']->value->subject;?>
" type="text" id="form-field-1" placeholder="Topic Subject" class="col-xs-10 col-sm-5" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label no-padding-right" for="form-field-1"> Topic Content</label>

                                    <div class="col-sm-9">
                                        <textarea name="content" class="col-xs-10 col-sm-5" id="form-field-1" placeholder="Topic Content"><?php echo $_smarty_tpl->tpl_vars['topic']->value->content;?>
</textarea>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label no-padding-right" for="form-field-1"></label>

                                    <div class="col-sm-9">
                                        <button class="btn btn-white btn-info btn-bold col-xs-10 col-sm-5">
                                            <i class="ace-icon fa fa-floppy-o bigger-120 blue"></i>
                                            Update
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
