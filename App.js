import React, { useState } from 'react';
import axios from 'axios';

function App() {
    const [englishWord, setEnglishWord] = useState('');
    const [translation, setTranslation] = useState('');

    const getTranslation = async () => {
        try {
            const response = await axios.get(`http://localhost:5000/api/dictionary/${englishWord}`);
            setTranslation(response.data);
        } catch (error) {
            setTranslation('Translation not found');
        }
    };

    return (
        <div style={{ padding: '20px', fontFamily: 'Arial, sans-serif' }}>
            <h1>English-Hungarian Dictionary</h1>
            <input
                type="text"
                value={englishWord}
                onChange={(e) => setEnglishWord(e.target.value)}
                placeholder="Enter English word"
                style={{ padding: '8px', margin: '10px' }}
            />
            <button onClick={getTranslation} style={{ padding: '8px 16px' }}>
                Translate
            </button>
            {translation && <p><strong>Hungarian Translation:</strong> {translation}</p>}
        </div>
    );
}

export default App;
