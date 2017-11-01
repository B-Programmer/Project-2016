<?php
/* Smarty version 3.1.30, created on 2016-10-01 16:07:40
  from "C:\VertrigoServ\www\ComputerScienceForum\administrator\app\views\forum\edit.tpl" */

/* @var Smarty_Internal_Template $_smarty_tpl */
if ($_smarty_tpl->_decodeProperties($_smarty_tpl, array (
  'version' => '3.1.30',
  'unifunc' => 'content_57efdf4c864bc8_76606211',
  'has_nocache_code' => false,
  'file_dependency' => 
  array (
    'f7485fe90001e01f249750b43c2f3e20eba237f0' => 
    array (
      0 => 'C:\\VertrigoServ\\www\\ComputerScienceForum\\administrator\\app\\views\\forum\\edit.tpl',
      1 => 1475337863,
      2 => 'file',
    ),
  ),
  'includes' => 
  array (
  ),
),false)) {
function content_57efdf4c864bc8_76606211 (Smarty_Internal_Template $_smarty_tpl) {
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

                            <!-- div.table-responsive -->
                            <form class="form-horizontal" role="form" action="?controller=forum&action=update" method="POST">
                                <input type="hidden" value="<?php echo $_smarty_tpl->tpl_vars['forum']->value->id;?>
" name="id" />
                                <div class="form-group">
                                    <label class="col-sm-3 control-label no-padding-right" for="form-field-1"> Forum Name </label>

                                    <div class="col-sm-9">
                                        <input name="forum_name" value="<?php echo $_smarty_tpl->tpl_vars['forum']->value->forum_name;?>
" type="text" id="form-field-1" placeholder="Forum Name" class="col-xs-10 col-sm-5" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label no-padding-right" for="form-field-1"> Forum Description</label>

                                    <div class="col-sm-9">
                                        <textarea name="forum_desc" class="col-xs-10 col-sm-5" id="form-field-1" placeholder="Forum Description"><?php echo $_smarty_tpl->tpl_vars['forum']->value->forum_desc;?>
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
