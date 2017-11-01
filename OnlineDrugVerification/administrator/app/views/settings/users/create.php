<p class="text-center">Create new user.</p>

<form id="demo-form2" method="post" action="?controller=settings&action=user_create" data-parsley-validate class="form-horizontal form-label-left">

    <div class="form-group">
        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="subject-name">Username<span class="required"> &ast; </span>
        </label>
        <div class="col-md-6 col-sm-6 col-xs-12">
            <input type="text" name="username" id="subject-name" required="required" class="form-control col-md-7 col-xs-12">
        </div>
    </div>
    <div class="form-group">
        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="quesions">Password <span class="required"> &ast;</span>
        </label>
        <div class="col-md-6 col-sm-6 col-xs-12">
            <input type="password" id="questions" name="password" required="required" class="form-control">
        </div>
    </div>
    <div class="form-group">
        <label class="control-label col-md-3 col-sm-3 col-xs-12">Select Permission</label>
        <div class="col-md-8 col-sm-8 col-xs-12">
            <select class="select2_single form-control" name="permission" required tabindex="-1">
                <option></option>
                <option>User</option>
                <option>Administrator</option>
            </select>
        </div>
    </div>
    <div class="ln_solid"></div>
    <div class="form-group">
        <div class="col-md-6 col-sm-6 col-xs-12 col-md-offset-3">
            <button type="submit" class="btn btn-success btn-block">Create New User</button>
        </div>
    </div>
</form>