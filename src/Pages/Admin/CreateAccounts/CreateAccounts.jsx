import React, { useState, useEffect } from "react";
import styles from "./CreateAccounts.module.css";
import {
  FaUser,
  FaEnvelope,
  FaLock,
  FaPhone,
  FaIdCard,
  FaCalendar,
} from "react-icons/fa";
import Header from "../../../components/Student/Header/Header";
import { useDarkMode } from "../../../contexts/ThemeContext";

const CreateStudentAccount = () => {
  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [gender, setGender] = useState(false);
  const [phoneNumber, setPhoneNumber] = useState("");
  const [nationalId, setNationalId] = useState("");
  const [year, setYear] = useState(false);
  const [role, setRole] = useState("student");
  const { isDarkMode } = useDarkMode();

  useEffect(() => {
    document.body.style.backgroundColor = isDarkMode ? "#121212" : "#f5f5f5";
  }, [isDarkMode]);

  const handleSubmit = async (e) => {
    e.preventDefault();
    const fullName = `${firstName} ${lastName}`.trim();

    const api_url = "";

    try {
      const response = await fetch(api_url, {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
          fullName,
          email,
          password,
          gender,
          phoneNumber,
          nationalId,
          year: role === "student",
          role,
        }),
      });

      const data = await response.json();
      console.log("Success:", data);
    } catch (error) {
      console.error("Error:", error);
    }
  };

  return (
    <>
      <Header />
      <div className={styles.container}>
        <h2 className={styles.title}>Create Student & Staff Account</h2>
        <p className={styles.subtitle}>
          Fill out the form below to create a new student or staff account.
        </p>

        <form className={styles.form} onSubmit={handleSubmit}>
          <div className={styles.roleSelection}>
            <label>
              <input
                type="radio"
                value="student"
                checked={role === "student"}
                onChange={() => setRole("student")}
              />
              Student
            </label>
            <label>
              <input
                type="radio"
                value="doctor"
                checked={role === "doctor"}
                onChange={() => setRole("doctor")}
              />
              Doctor
            </label>
          </div>

          <div className={styles.inputGroup}>
            <div className={styles.inputWithIcon}>
              <FaUser className={styles.icon} />
              <input
                type="text"
                placeholder="First Name"
                value={firstName}
                onChange={(e) => setFirstName(e.target.value)}
                required
                className={styles.input}
              />
            </div>

            <div className={styles.inputWithIcon}>
              <FaUser className={styles.icon} />
              <input
                type="text"
                placeholder="Last Name"
                value={lastName}
                onChange={(e) => setLastName(e.target.value)}
                required
                className={styles.input}
              />
            </div>
          </div>

          <div className={styles.inputWithIcon}>
            <FaEnvelope className={styles.icon} />
            <input
              type="email"
              placeholder="Email"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
              required
              className={styles.inputFullWidth}
            />
          </div>

          <div className={styles.inputWithIcon}>
            <FaLock className={styles.icon} />
            <input
              type="password"
              placeholder="Password"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
              required
              className={styles.inputFullWidth}
            />
          </div>

          <div className={styles.inputWithIcon}>
            <FaPhone className={styles.icon} />
            <input
              type="tel"
              placeholder="Phone Number"
              value={phoneNumber}
              onChange={(e) => setPhoneNumber(e.target.value)}
              required
              className={styles.inputFullWidth}
            />
          </div>

          <div className={styles.inputWithIcon}>
            <FaIdCard className={styles.icon} />
            <input
              type="text"
              placeholder="National ID"
              value={nationalId}
              onChange={(e) => setNationalId(e.target.value)}
              required
              className={styles.inputFullWidth}
            />
          </div>

          <div className={styles.inputWithIcon}>
            <label>Gender</label>
            <div>
              <input
                type="checkbox"
                checked={gender}
                onChange={(e) => setGender(e.target.checked)}
                className={styles.checkbox}
              />
              <span>{gender ? "Male" : "Female"}</span>
            </div>
          </div>

          <div className={styles.inputWithIcon}>
            <FaCalendar className={styles.icon} />
            <input
              type="checkbox"
              checked={year}
              onChange={(e) => setYear(e.target.checked)}
              disabled={role === "doctor"}
              className={styles.checkbox}
            />
            <label>Is Student?</label>
          </div>

          <p className={styles.passwordNote}>
            Password must be at least 8 characters long.
          </p>

          <button type="submit" className={styles.submitButton}>
            Create Account
          </button>
        </form>
      </div>
    </>
  );
};

export default CreateStudentAccount;
