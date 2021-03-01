@{
    ViewData["Title"] = "CREATE YOUR ACCOUNT";
}
<h1>@ViewData["Title"]</h1>
<html>
<head>
    <style>
        .btnSubmit {
            font-weight: 600;
            color: #fff;
            background-color: #0062cc;
        }
    </style>
</head>
<body>
    <div class="container login-container">
        <div class="row">
            <div class="col-md-6 register-1">
                <img src="/images/register2.jpg" style="width:100%;height:100%"/>
            </div>
            <div class="col-md-6 register-2">
                <h3>REGISTER</h3>
                <form>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col">
                                <input type="text" class="form-control" placeholder="First name">
                            </div>
                            <div class="col">
                                <input type="text" class="form-control" placeholder="Last name">
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <input type="email" class="form-control" id="email" placeholder="Email id" value="" />
                    </div>
                    <div class="form-group">
                        <input type="password" class="form-control" placeholder="Enter Password *" value="" />
                    </div>
                    <div class="form-group">
                        <input type="password" class="form-control" placeholder="Confirm Password *" value="" />
                    </div>
                    <div class="form-group">
                        <input type="submit" class="btnSubmit" value="Register" />
                    </div>
                </form>
            </div>
        </div>
    </div>
</body>
</html>
