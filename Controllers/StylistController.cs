[HttpGet("/Stylist")]
    public ActionResult Index()
    {

        return View(new SalonContext().stylist.ToList());
    }
