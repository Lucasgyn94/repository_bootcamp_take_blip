import React, { useState } from 'react';
import styled from 'styled-components';
import Estilos from './parte-1/Estilos';

const ClassRoom = styled.div`
	display: flex;
	flex-direction: column;
`;

const ClassRoomControls = styled.div`
	display: flex;
	justify-content: space-around;
	margin: 0;
	background: #5f6aff;
	padding: 10px;
`;

const ClassRoomBoard = styled.div`
	margin: 12px;
	display: flex;
	justify-content: center;
`;

const Aula1 = () => {
	const [topic, setTopic] = useState(1);

	return (
		<ClassRoom>
			<ClassRoomControls>
				<button onClick={() => setTopic(1)}>Tópico 1</button>
			</ClassRoomControls>
			<ClassRoomBoard>
				{topic === 1 && <Estilos />}
			</ClassRoomBoard>
		</ClassRoom>
	);
}

export default Aula1;