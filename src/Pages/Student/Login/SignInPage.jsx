import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import { Link } from "react-router-dom";
import styles from "./SignInForm.module.css";
import FormInput from "../FormInput/FormInput";
import Button from "../Button/Button";

const SignInForm = () => {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [termsAccepted, setTermsAccepted] = useState(false);
  const navigate = useNavigate();

  const handleLogin = async () => {
    const api_url = "";
    try {
      const response = await fetch(api_url, {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({ email, password }),
      });

      if (!response.ok) {
        throw new Error("failed");
      }

      const data = await response.json();
      console.log("Success:", data);

      navigate("/");
    } catch (error) {
      console.error("Error:", error);
    }
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    if (!termsAccepted) {
      alert("You must accept the Terms & Conditions.");
      return;
    }
    handleLogin();
  };

  return (
    <div className={styles.signupContainer}>
      <form className={styles.form} onSubmit={handleSubmit}>
        <h2>Start Learning Today!</h2>
        <p>Log in to explore your courses and track your progress.</p>
        <FormInput
          type="email"
          placeholder="Email"
          value={email}
          onChange={(e) => setEmail(e.target.value)}
        />
        <FormInput
          type="password"
          placeholder="Enter your password"
          value={password}
          onChange={(e) => setPassword(e.target.value)}
        />
        <div className={styles.terms}>
          <input
            type="checkbox"
            id="terms"
            className={styles.check}
            checked={termsAccepted}
            onChange={() => setTermsAccepted(!termsAccepted)}
          />
          <label htmlFor="terms">
            I agree to the <Link to="/terms">Terms & Conditions</Link>{" "}
          </label>
        </div>
        <Button className={styles.login} type="submit">
          Login
        </Button>
      </form>
    </div>
  );
};

export default SignInForm;
