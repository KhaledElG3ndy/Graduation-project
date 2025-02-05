import React from "react";
import styles from "./SectionCard.module.css";
import { useDarkMode } from "../../../contexts/ThemeContext";

const SectionCard = ({ title, description, buttonText, image }) => {
  const { isDarkMode } = useDarkMode();

  return (
    <div
      className={`${styles.card} ${
        isDarkMode ? styles.darkMode : styles.lightMode
      }`}
      data-aos="zoom-in"
    >
      <div className={styles.imageContainer}>
        <img src={image} alt={title} className={styles.image} />
      </div>
      <h3
        className={`${styles.title} ${
          isDarkMode ? styles.lightText : styles.darkText
        }`}
      >
        {title}
      </h3>
      <p
        className={`${styles.description} ${
          isDarkMode ? styles.lightText : styles.darkText
        }`}
      >
        {description}
      </p>
      <button className={styles.button}>{buttonText}</button>
    </div>
  );
};
export default SectionCard;
