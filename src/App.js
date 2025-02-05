import React, { useEffect } from "react";
import "./index.css";
import { Routes, Route } from "react-router-dom";

import SignInPage from "./Pages/Student/Login/SignInPage";
import Home from "./Pages/Student/Home/Home";
import AdminCreateAccounts from "./Pages/Admin/CreateAccounts/CreateAccounts";
import AdminHomePage from "./Pages/Admin/Home/Home";
import Professor from "./Pages/Professor/Home";

import AOS from "aos";
import "aos/dist/aos.css";

import { DarkModeProvider } from "./contexts/ThemeContext";

function App() {
  useEffect(() => {
    AOS.init({
      duration: 1000,
      offset: 120,
      easing: "ease-in-out",
      once: true,
    });
  }, []);

  return (
    <DarkModeProvider>
      <div className="App">
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/Login/signin" element={<SignInPage />} />
          <Route path="/Admin" element={<AdminHomePage />} />
          <Route path="/Professor" element={<Professor />} />
          <Route
            path="/Admin/CreateAccounts"
            element={<AdminCreateAccounts />}
          />
        </Routes>
      </div>
    </DarkModeProvider>
  );
}

export default App;
