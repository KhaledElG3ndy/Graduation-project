import React, { useEffect, useContext } from "react";
import "./index.css";
import { Routes, Route } from "react-router-dom";

import SignInPage from "./Pages/Student/Login/SignInPage";
import Home from "./Pages/Student/Home/Home";
import AdminCreateAccounts from "./Pages/Admin/CreateAccounts/CreateAccounts";
import AdminHomePage from "./Pages/Admin/Home/Home";
import Professor from "./Pages/Professor/Home";

import AOS from "aos";
import "aos/dist/aos.css";

import { useDarkMode } from "./contexts/ThemeContext";

function App() {
  const { isDarkMode, toggleTheme } = useDarkMode();

  useEffect(() => {
    AOS.init({
      duration: 1000,
      easing: "ease-in-out",
      once: true,
    });
  }, []);

  useEffect(() => {
    document.body.className = isDarkMode ? "darkMode" : "lightMode";
  }, [isDarkMode]);

  return (
    <div className="App">
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/Login/signin" element={<SignInPage />} />
        <Route path="/Admin" element={<AdminHomePage />} />
        <Route path="/Professor" element={<Professor />} />
        <Route path="/Admin/CreateAccounts" element={<AdminCreateAccounts />} />
      </Routes>
    </div>
  );
}

export default App;
