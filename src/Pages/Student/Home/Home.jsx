import React from "react";
import styles from "./Home.module.css";
import Header from "../../../components/Student/Header/Header";
import SectionCard from "../../../components/Student/SectionCard/SectionCard";
import Footer from "../../../components/Student/Footer/Footer";
import { useDarkMode } from "../../../contexts/ThemeContext";

import img from "../../../assets/images/img.svg";
import news from "../../../assets/images/news.svg";
import schedule from "../../../assets/images/Schedules.svg";
import guide from "../../../assets/images/guidance.svg";
import Communication from "../../../assets/images/Communication.svg";
import study from "../../../assets/images/study1.svg";

const Home = () => {
  const { isDarkMode } = useDarkMode();

  const sections = [
    {
      id: 1,
      title: "Study",
      description:
        "Access study materials and enhance your learning experience.",
      buttonText: "Explore Study",
      image: study,
    },
    {
      id: 2,
      title: "News",
      description:
        "Stay updated with the latest college news and announcements.",
      buttonText: "Read News",
      image: news,
    },
    {
      id: 3,
      title: "Communication",
      description: "Connect with peers and faculty seamlessly.",
      buttonText: "Start Communicating",
      image: Communication,
    },
    {
      id: 4,
      title: "Guidance",
      description: "Get advice and guidance from academic counselors.",
      buttonText: "Seek Guidance",
      image: guide,
    },
    {
      id: 5,
      title: "Schedules",
      description: "Check class schedules and faculty office hours easily.",
      buttonText: "View Schedule",
      image: schedule,
    },
  ];

  return (
    <div>
      <Header />
      <div
        className={`${styles.homeContainer} ${
          isDarkMode ? styles.darkMode : styles.lightMode
        }`}
      >
        <div className={styles.textContent}>
          <h1>Streamline Your College Life</h1>
          <p className={isDarkMode ? styles.lightText : styles.darkText}>
            Online education enables students to learn from anywhere, leveraging
            the power of technology for a flexible and efficient educational
            experience.
          </p>

          <div className={styles.buttons}>
            <button className={styles.primaryButton}>Get Started</button>
            <button className={styles.secondaryButton}>Learn More</button>
          </div>
        </div>
        <div className={styles.imageContainer}>
          <img
            src={img}
            alt="Streamline your college life"
            className={styles.image}
          />
        </div>
      </div>

      <div
        className={`${styles.sectionContainer} ${
          isDarkMode ? styles.darkMode : styles.lightMode
        }`}
      >
        {sections.map((section) => (
          <SectionCard key={section.id} {...section} />
        ))}
      </div>

      <Footer />
    </div>
  );
};

export default Home;
