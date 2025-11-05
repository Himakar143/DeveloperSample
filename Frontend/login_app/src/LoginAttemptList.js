import React, { useState } from "react";
import "./LoginAttemptList.css";

const LoginAttempt = ({ login }) => (
    <li className="bg-white p-3 mb-2 rounded">
        <strong>Login:</strong> {login}
    </li>
);

const LoginAttemptList = ({ attempts }) => {
    const [filter, setFilter] = useState("");

    const filteredAttempts = attempts.filter(attempt => 
        attempt.login.toLowerCase().includes(filter.toLowerCase())
    );

    return (
        <div className="max-w-md mx-auto mt-5 p-5 bg-gray-100 rounded">
            <p className="mb-3">Recent activity</p>
            <input 
                type="text" 
                placeholder="Filter..." 
                value={filter}
                onChange={(e) => setFilter(e.target.value)}
                className="w-full p-2 border rounded mb-3"
            />
            <ul>
                {filteredAttempts.length > 0 ? (
                    filteredAttempts.map((attempt, index) => (
                        <LoginAttempt 
                            key={index}
                            login={attempt.login}
                        />
                    ))
                ) : (
                    <li className="p-3 text-gray-500">No login attempts yet</li>
                )}
            </ul>
        </div>
    );
};

export default LoginAttemptList;