import React from "react";
import styles from "./Home.module.css";
import Header from "../../components/Professor/Header/Header";
import Footer from "../../components/Professor/Footer/Footer";
import { useDarkMode } from "../../contexts/ThemeContext";

const ProfessorHomePage = () => {
  const { isDarkMode } = useDarkMode();

  return (
    <div className={styles.profHome}>
      <Header />
      <div
        className={`${styles.homeContainer} ${
          isDarkMode ? styles.darkMode : styles.lightMode
        }`}
      >
        <div className={styles.textContent}>
          <h1>Enhance Your Teaching Experience</h1>
          <p className={isDarkMode ? styles.lightText : styles.darkText}>
            Online education empowers professors to connect with students
            seamlessly, leveraging technology for an engaging and efficient
            learning environment.
          </p>

          <div className={styles.buttons}>
            <button className={styles.primaryButton}>Channels</button>
            <button className={styles.secondaryButton}>Manage Subject</button>
          </div>
        </div>
      </div>

      <Footer />
    </div>
  );
};

export default ProfessorHomePage;
