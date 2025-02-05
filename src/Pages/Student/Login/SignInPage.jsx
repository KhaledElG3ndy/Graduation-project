import React from "react";
import styles from "./SignInPage.module.css";
import SignInForm from "../../../components/Student/SignInForm/SignInForm";
import { FaArrowRight } from "react-icons/fa6";

const SignInPage = () => {
  return (
    <div className={styles.container}>
      <div className={styles.imageSection}>
        <a href="/" className={styles.backToWebsite}>
          Back to website
          <FaArrowRight />
        </a>
        <div className={styles.overlay}>
          <h1>Streamline Your College Life</h1>
          <div className={styles.pagination}>
            <span className={styles.dot}></span>
            <span className={styles.dot}></span>
            <span className={styles.dot}></span>
          </div>
        </div>
      </div>
      <div className={styles.formSection}>
        <SignInForm />
      </div>
    </div>
  );
};

export default SignInPage;
