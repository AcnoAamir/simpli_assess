import React from "react";
import { Link } from "react-router-dom";

function Navbar() {
  return (
    <nav className="navbar navbar-expand-lg navbar-light bg-dark">
      <Link className="navbar-brand text-white" href="#">
        FindMyEvents
      </Link>
      <button
        className="navbar-toggler"
        type="button"
        data-toggle="collapse"
        data-target="#navbarSupportedContent"
        aria-controls="navbarSupportedContent"
        aria-expanded="false"
        aria-label="Toggle navigation"
      >
        <span>
          <i className="fas fa-bars" style={{ color: "#fff" }} />
        </span>
      </button>

      <div className="collapse navbar-collapse" id="navbarSupportedContent">
        <ul className="navbar-nav m-auto">
          <li className="nav-item active">
            <Link className="nav-link text-white text-uppercase ml-5" to="/">
              Home &nbsp;<i class="fas fa-home"></i>{" "}
              <span class="sr-only">(current)</span>
            </Link>
          </li>
          <li className="nav-item">
            <Link
              className="nav-link  text-white text-uppercase ml-5"
              to="/about"
            >
              about us &nbsp;<i class="fas fa-users"></i>
            </Link>
          </li>
          <li className="nav-item">
            <Link
              className="nav-link  text-white text-uppercase ml-5"
              to="/contacts"
            >
              contact us &nbsp; <i class="fas fa-address-card"></i>
            </Link>
          </li>
        </ul>

        <Link className="nav-link  text-white text-uppercase ml-5" to="/login">
          <form className="form-inline my-2 my-lg-0">
            <button
              className="btn btn-outline-primary my-2 my-sm-0"
              type="submit"
            >
              Login
            </button>
          </form>
        </Link>
      </div>
    </nav>
  );
}
export default Navbar;
