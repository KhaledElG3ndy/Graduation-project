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
        "Gain access to a comprehensive collection of study materials, including lecture notes, e-books, and practice questions. Enhance your learning experience with interactive resources tailored to your courses.",
      buttonText: "Explore Study",
      image: study,
    },
    {
      id: 2,
      title: "News",
      description:
        "Stay informed with the latest updates from your college, including important announcements, event schedules, policy changes, and achievements. Never miss out on crucial information about campus life.",
      buttonText: "Read News",
      image: news,
    },
    {
      id: 3,
      title: "Communication",
      description:
        "Effortlessly connect with classmates, professors, and academic staff through chat, forums, and discussion boards. Share ideas, collaborate on projects, and stay engaged with your academic community.",
      buttonText: "Start Communicating",
      image: Communication,
    },
    {
      id: 4,
      title: "Guidance",
      description:
        "Receive personalized academic advice and career counseling from experienced mentors. Get support for course selection, career planning, and skill development to achieve your academic and professional goals.",
      buttonText: "Seek Guidance",
      image: guide,
    },
    {
      id: 5,
      title: "Schedules",
      description:
        "Easily check your class schedules, faculty office hours, and exam timetables. Stay organized and plan your academic activities efficiently with up-to-date scheduling information.",
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
          <h1>Empower Your College Journey</h1>
          <p className={isDarkMode ? styles.lightText : styles.darkText}>
            Manage your studies, stay updated with campus events, and connect
            with your academic community—all in one platform.
          </p>

          <div className={styles.buttons}>
            <button className={styles.primaryButton}>Get Started</button>
            <button className={styles.secondaryButton}>Learn More</button>
          </div>
        </div>
        <div className={styles.imageContainer}>
          <img
            src={img}
            alt="Empower your college journey"
            className={styles.image}
          />
        </div>
      </div>
      <div
        className={`${styles.cardsContainer} ${
          isDarkMode ? styles.darkMode : styles.lightMode
        }`}
      >
        <div
          className={`${styles.sectionContainer} ${
            isDarkMode ? styles.darkMode : styles.lightMode
          }`}
        >
          {sections.map((section) => (
            <SectionCard key={section.id} {...section} />
          ))}
        </div>
      </div>

      <Footer />
    </div>
  );
};

export default Home;
