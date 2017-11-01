<?php
/* Smarty version 3.1.30, created on 2016-09-30 12:42:34
  from "C:\VertrigoServ\www\ComputerScienceForum\administrator\app\views\slider\index.tpl" */

/* @var Smarty_Internal_Template $_smarty_tpl */
if ($_smarty_tpl->_decodeProperties($_smarty_tpl, array (
  'version' => '3.1.30',
  'unifunc' => 'content_57ee5dbad64740_02437160',
  'has_nocache_code' => false,
  'file_dependency' => 
  array (
    '703d5e1d6e70cdaaef1d150454f0b0e52751fc68' => 
    array (
      0 => 'C:\\VertrigoServ\\www\\ComputerScienceForum\\administrator\\app\\views\\slider\\index.tpl',
      1 => 1474320316,
      2 => 'file',
    ),
  ),
  'includes' => 
  array (
  ),
),false)) {
function content_57ee5dbad64740_02437160 (Smarty_Internal_Template $_smarty_tpl) {
if (!is_callable('smarty_function_counter')) require_once 'C:\\VertrigoServ\\www\\ComputerScienceForum\\administrator\\vendor\\smarty\\smarty\\libs\\plugins\\function.counter.php';
?>
<!-- page content -->
<div class="right_col" role="main">
    <div class="">
        <div class="page-title"><br><br><br>

            <div class="title_left">
                <h3>
                    Sliders
                    <small>
                        create, edit and delete sliders
                    </small>
                </h3>
            </div>

            <div class="title_right">
                <div class="col-md-5 col-sm-5 col-xs-12 form-group pull-right top_search">
                    <a class="btn btn-info btn-block" href="?controller=slider&action=create"><i class="fa fa-file-text"></i>&nbsp;Create New Slider</a>
                </div>
            </div>
        </div>
        <div class="clearfix"></div>

        <div class="row">

            <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="x_panel">
                    <div class="x_title">
                        <h2>List Of Sliders</h2>
                        <div class="clearfix"></div>
                    </div>
                    <div class="x_content">

                        <table id="datatable" class="table table-striped table-bordered">
                            <thead>
                                <tr>
                                    <th>S/N</th>
                                    <th>Caption</th>
                                    <th>Description</th>
                                    <th>Picture</th>
                                    <th>Actions</th>
                                </tr>
                            </thead>


                            <tbody>
                                <?php
$_from = $_smarty_tpl->smarty->ext->_foreach->init($_smarty_tpl, $_smarty_tpl->tpl_vars['sliders']->value, 'slider');
if ($_from !== null) {
foreach ($_from as $_smarty_tpl->tpl_vars['slider']->value) {
?>
                                    <tr>
                                        <td><?php echo smarty_function_counter(array(),$_smarty_tpl);?>
</td>
                                        <td><?php echo $_smarty_tpl->tpl_vars['slider']->value->caption;?>
</td>
                                        <td><?php echo $_smarty_tpl->tpl_vars['slider']->value->description;?>
</td>
                                        <td><img class="img-responsive" src="<?php echo $_smarty_tpl->tpl_vars['thumbs_url']->value;
echo $_smarty_tpl->tpl_vars['slider']->value->picture;?>
" /></td>
                                        <td>
                                            <a class="btn btn-warning" href="?controller=slider&action=edit&id=<?php echo $_smarty_tpl->tpl_vars['slider']->value->id;?>
"><i class="fa fa-edit"></i>&nbsp;Edit</a>
                                            <a class="btn btn-danger" href="?controller=slider&action=delete&id=<?php echo $_smarty_tpl->tpl_vars['slider']->value->id;?>
"><i class="fa fa-trash"></i>&nbsp;Delete</a>
                                        </td>
                                    </tr>                                
                                <?php
}
}
$_smarty_tpl->smarty->ext->_foreach->restore($_smarty_tpl);
?>

                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- /page content --><?php }
}
